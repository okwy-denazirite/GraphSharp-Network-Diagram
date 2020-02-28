using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using QuickGraph;

namespace GraphSharp.Algorithms.Layout.Simple.Grid
{
    public class GridLayoutAlgorithm<TVertex, TEdge, TGraph> : DefaultParameterizedLayoutAlgorithmBase<TVertex, TEdge, TGraph, GridLayoutParameters>
        where TVertex : class
        where TEdge : IEdge<TVertex>
        where TGraph : IBidirectionalGraph<TVertex, TEdge>
    {
        private readonly IDictionary<TVertex, Size> _vertexSizes;

        public GridLayoutAlgorithm(TGraph visitedGraph, IDictionary<TVertex, Point> vertexPositions,
            IDictionary<TVertex, Size> vertexSizes, GridLayoutParameters parameters)
            : base(visitedGraph, vertexPositions, parameters)
        {
            _vertexSizes = vertexSizes;
        }

        protected override void InternalCompute()
        {
            var autoRowHeights = new Dictionary<int, double>();
            var autoColumnWidths = new Dictionary<int, double>();
            var autoRows = new HashSet<int>(Parameters.Rows.Where(r => r.AutoHeight).Select((r, i) => i));
            var autoColumns = new HashSet<int>(Parameters.Columns.Where(c => c.AutoWidth).Select((c, i) => i));
            int curRow = 0, curColumn = 0;
            if (autoRows.Count > 0 || autoColumns.Count > 0)
            {
                foreach (TVertex vertex in VisitedGraph.Vertices)
                {
                    GridVertexInfo info = Parameters.GetVertexInfo(vertex);
                    int row, column, rowSpan, columnSpan;
                    if (info != null)
                    {
                        row = info.Row;
                        column = info.Column;
                        rowSpan = info.RowSpan;
                        columnSpan = info.ColumnSpan;
                    }
                    else
                    {
                        row = curRow++;
                        if (curRow >= Parameters.Rows.Count)
                            break;
                        column = curColumn++;
                        if (curColumn >= Parameters.Columns.Count)
                            curColumn = 0;
                        rowSpan = 1;
                        columnSpan = 1;
                    }


                    Size sz = _vertexSizes[vertex];
                    if (rowSpan == 1 && autoRows.Contains(row))
                    {
                        double height = GetValue(autoRowHeights, row);
                        autoRowHeights[row] = Math.Max(height, sz.Height);
                    }
                    if (columnSpan == 1 && autoColumns.Contains(column))
                    {
                        double width = GetValue(autoColumnWidths, column);
                        autoColumnWidths[column] = Math.Max(width, sz.Width);
                    }
                }
            }

            curRow = 0;
            curColumn = 0;
            foreach (TVertex vertex in VisitedGraph.Vertices)
            {
                GridVertexInfo info = Parameters.GetVertexInfo(vertex);
                int row, column, rowSpan, columnSpan;
                GridHorizontalAlignment horzAlign;
                GridVerticalAlignment vertAlign;
                if (info != null)
                {
                    row = info.Row;
                    column = info.Column;
                    rowSpan = info.RowSpan;
                    columnSpan = info.ColumnSpan;
                    horzAlign = info.HorizontalAlignment;
                    vertAlign = info.VerticalAlignment;
                }
                else
                {
                    row = curRow++;
                    if (curRow >= Parameters.Rows.Count)
                        break;
                    column = curColumn++;
                    if (curColumn >= Parameters.Columns.Count)
                        curColumn = 0;
                    rowSpan = 1;
                    columnSpan = 1;
                    horzAlign = GridHorizontalAlignment.Center;
                    vertAlign = GridVerticalAlignment.Center;
                }
                Size sz = _vertexSizes[vertex];
                Rect rect = GetRect(row, column, rowSpan, columnSpan, autoRowHeights, autoColumnWidths);
                double x = 0;
                switch (horzAlign)
                {
                    case GridHorizontalAlignment.Left:
                        x = rect.Left + sz.Width / 2;
                        break;

                    case GridHorizontalAlignment.Center:
                        x = rect.Left + rect.Width / 2;
                        break;

                    case GridHorizontalAlignment.Right:
                        x = rect.Right - sz.Width / 2;
                        break;
                }

                double y = 0;
                switch (vertAlign)
                {
                    case GridVerticalAlignment.Top:
                        y = rect.Top + sz.Height / 2;
                        break;

                    case GridVerticalAlignment.Center:
                        y = rect.Top + rect.Height / 2;
                        break;

                    case GridVerticalAlignment.Bottom:
                        y = rect.Bottom - sz.Height / 2;
                        break;
                }
                VertexPositions[vertex] = new Point(x, y);
            }
        }

        private Rect GetRect(int row, int column, int rowSpan, int columnSpan, Dictionary<int, double> autoRowHeights, Dictionary<int, double> autoColumnWidths)
        {
            double x = Parameters.Columns.Take(column).Select((c, i) => (c.AutoWidth ? GetValue(autoColumnWidths, i) : c.Width) + Parameters.GridThickness).Sum();
            double y = Parameters.Rows.Take(row).Select((r, i) => (r.AutoHeight ? GetValue(autoRowHeights, i) : r.Height) + Parameters.GridThickness).Sum();

            double width = 0;
            for (int i = column; i < column + columnSpan; i++)
            {
                width += Parameters.Columns[i].AutoWidth ? GetValue(autoColumnWidths, i) : Parameters.Columns[i].Width;
                if (i > column)
                    width += Parameters.GridThickness;
            }

            double height = 0;
            for (int i = row; i < row + rowSpan; i++)
            {
                height += Parameters.Rows[i].AutoHeight ? GetValue(autoRowHeights, i) : Parameters.Rows[i].Height;
                if (i > row)
                    height += Parameters.GridThickness;
            }

            return new Rect(x, y, width, height);
        }

        public static double GetValue(Dictionary<int, double> dictionary, int key)
        {
            double value;
            if (!dictionary.TryGetValue(key, out value))
                value = 0;
            return value;
        }
    }
}
