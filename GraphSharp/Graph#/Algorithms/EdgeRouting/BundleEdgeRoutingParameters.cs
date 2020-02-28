namespace GraphSharp.Algorithms.EdgeRouting
{
	public class BundleEdgeRoutingParameters : EdgeRoutingParameters
	{
		private double _vertexMargin;
		private double _inkCoefficient = 100;
		private double _lengthCoefficient = 500;

		public double VertexMargin
		{
			get { return _vertexMargin; }
			set 
			{
				_vertexMargin = value;
				NotifyChanged("VertexMargin");
			}
		}

		public double InkCoefficient
		{
			get { return _inkCoefficient; }
			set
			{
				_inkCoefficient = value;
				NotifyChanged("InkCoefficient");
			}
		}

		public double LengthCoefficient
		{
			get { return _lengthCoefficient; }
			set
			{
				_lengthCoefficient = value;
				NotifyChanged("LengthCoefficient");
			}
		}
	}
}
