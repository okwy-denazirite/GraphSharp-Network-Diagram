using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace GraphSharp.Converters
{
	public class EdgeRouteToPathConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			Debug.Assert( values != null && values.Length == 12, "EdgeRouteToPathConverter should have 10 parameters: pos (0, 1), size (2, 3) of source; pos (4, 5), size (6, 7) of target; routeInformation (8); directed (9); angle (10) of source; angle (11) of target." );
			var sourcePos = new Point
				{
					X = values[0] != DependencyProperty.UnsetValue ? (double) values[0] : 0.0,
					Y = values[1] != DependencyProperty.UnsetValue ? (double) values[1] : 0.0
				};
			//get the size of the source
			var sourceSize = new Size
				{
					Width = values[2] != DependencyProperty.UnsetValue ? (double) values[2] : 0.0,
					Height = values[3] != DependencyProperty.UnsetValue ? (double) values[3] : 0.0
				};
			//get the position of the target
			var targetPos = new Point
				{
					X = values[4] != DependencyProperty.UnsetValue ? (double) values[4] : 0.0,
					Y = values[5] != DependencyProperty.UnsetValue ? (double) values[5] : 0.0
				};
			//get the size of the target
			var targetSize = new Size
				{
					Width = values[6] != DependencyProperty.UnsetValue ? (double) values[6] : 0.0,
					Height = values[7] != DependencyProperty.UnsetValue ? (double) values[7] : 0.0
				};

			//get the route informations
			Point[] routeInformation = values[8] != DependencyProperty.UnsetValue ? (Point[]) values[8] : null;

			bool directed = values[9] == DependencyProperty.UnsetValue || (bool) values[9];

		    double sourceAngle = values[10] != DependencyProperty.UnsetValue ? (double) values[10] : 0.0;
            double targetAngle = values[11] != DependencyProperty.UnsetValue ? (double) values[11] : 0.0;

		    if (double.IsNaN(sourcePos.X) || double.IsNaN(sourcePos.Y) || double.IsNaN(targetPos.X) || double.IsNaN(targetPos.Y))
		        return DependencyProperty.UnsetValue;

			bool hasRouteInfo = routeInformation != null && routeInformation.Length > 0;

			Point p1 = CalculateAttachPoint(sourceAngle, sourcePos, sourceSize, hasRouteInfo ? routeInformation[0] : targetPos);
			Point p2 = CalculateAttachPoint(targetAngle, targetPos, targetSize, hasRouteInfo ? routeInformation[routeInformation.Length - 1] : sourcePos);

			var edgeFigure = new PathFigure {StartPoint = p1};
			if (hasRouteInfo)
			{
				edgeFigure.Segments.Add(new LineSegment(routeInformation[0], true));
				var pts = new List<Point>(routeInformation.Length + 2) {p1};
				pts.AddRange(routeInformation);
				pts.Add(p2);
				for (int i = 1; i < pts.Count - 1; i++)
					ConnectLinePoints(edgeFigure, pts[i - 1], pts[i], pts[i + 1], 5);
			}
			else
			{
				edgeFigure.Segments.Add(new LineSegment(p2, true));
			}

			var pfc = new PathFigureCollection {edgeFigure};

			if (directed)
			{
				Point pLast = hasRouteInfo ? routeInformation[routeInformation.Length - 1] : p1;
				Vector v = pLast - p2;
				v = v / v.Length * 5;
				Vector n = new Vector(-v.Y, v.X) * 0.3;
				var arrowFigure = new PathFigure(p2, new PathSegment[]
					{
						new LineSegment(p2 + v - n, true),
						new LineSegment(p2 + v + n, true)
					}, true);
				pfc.Add(arrowFigure);
			}

			return pfc;
		}

		private static Point CalculateAttachPoint(double angle, Point s, Size sourceSize, Point t)
		{
		    if (Math.Abs(sourceSize.Width - 0) < double.Epsilon && Math.Abs(sourceSize.Height - 0) < double.Epsilon)
		        return s;

		    var matrix = new Matrix();
            matrix.RotateAt(angle, s.X, s.Y);

		    var topLeft = new Point(s.X - (sourceSize.Width / 2), s.Y - (sourceSize.Height / 2));
		    var points = new[]
		        {
		            topLeft,
                    new Point(topLeft.X + sourceSize.Width, topLeft.Y),
                    new Point(topLeft.X + sourceSize.Width, topLeft.Y + sourceSize.Height),
                    new Point(topLeft.X, topLeft.Y + sourceSize.Height)
		        };

		    matrix.Transform(points);

            for (int i = 0; i < points.Length; i++)
            {
                Point attachPoint;
		        if (Intersects(s, t, points[i], points[(i + 1) % points.Length], out attachPoint))
		            return attachPoint;
            }

		    return s;
		}

        private static bool Intersects(Point a1, Point a2, Point b1, Point b2, out Point intersection)
        {
            intersection = new Point();

            Vector b = a2 - a1;
            Vector d = b2 - b1;

            double bdotd = b.X * d.Y - b.Y * d.X;

            if (Math.Abs(bdotd - 0) < double.Epsilon)
                return false;

            Vector c = b1 - a1;
            double t = (c.X * d.Y - c.Y * d.X) / bdotd;
            if (t < 0 || t > 1)
                return false;

            double u = (c.X * b.Y - c.Y * b.X) / bdotd;
            if (u < 0 || u > 1)
                return false;

            intersection = a1 + t * b;
            return true;
        }

		private static void ConnectLinePoints(PathFigure pathFigure, Point p1, Point p2, Point p3, double roundness)
		{
			//The point on the first segment where the curve will start.
			//The point on the second segment where the curve will end.
			Point nextPoint, backPoint;
			if (GetPointAtDistance(p2, p3, roundness, true, out nextPoint) && GetPointAtDistance(p1, p2, roundness, false, out backPoint))
			{
				int lastSegmentIndex = pathFigure.Segments.Count - 1;
				//Set the ending point of the first segment.
				((LineSegment) (pathFigure.Segments[lastSegmentIndex])).Point = backPoint;

				//Create and add the curve.
				var curve = new QuadraticBezierSegment(p2, nextPoint, true);
				pathFigure.Segments.Add(curve);
			}
			//Create and add the new segment.
			var line = new LineSegment(p3, true);
			pathFigure.Segments.Add(line);
		}

		private static bool GetPointAtDistance(Point p1, Point p2, double distance, bool firstPoint, out Point point)
		{
			double totalDistance = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
			if (totalDistance <= distance)
			{
				point = new Point();
				return false;
			}
			double rap = firstPoint ? distance / totalDistance : (totalDistance - distance) / totalDistance;
			point = new Point(p1.X + (rap * (p2.X - p1.X)), p1.Y + (rap * (p2.Y - p1.Y)));
			return true;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
