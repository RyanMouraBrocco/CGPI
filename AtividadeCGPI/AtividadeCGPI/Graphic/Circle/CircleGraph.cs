using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI.Graphic.Circle
{
    public class CircleGraph : Circle, IGraph
    {
        private int DefaultLength { get { return 5; } }
        public int Length { get; set; }
        public Color Color { get; set; }

        public CircleGraph() : base()
        {
            Length = DefaultLength;
            Color = Color.Black;
        }

        public CircleGraph(PointGraph centerPoint, PointGraph extremePoint) : base(centerPoint, extremePoint)
        {
            Length = DefaultLength;
            Color = Color.Black;
        }

        public CircleGraph(PointGraph centerPoint, PointGraph extremePoint, int length, Color color)
        {
            CenterPoint = centerPoint;
            ExtremePoint = extremePoint;
            Length = length;
            Color = color;
        }

        public void Draw(Control drawingBase)
        {
            List<PointGraph> allPoints = GeneratePoints();
            GraphicUtils.DrawAllPoints(allPoints, drawingBase);
        }

        private List<PointGraph> GeneratePoints()
        {
            List<PointGraph> points = new List<PointGraph>();

            for (int i = 0; i <= 1000; i++)
            {
                PointGraph newPoint = new PointGraph();
                newPoint.PositionX = (int)CalculateXValue(i);
                newPoint.PositionY = (int)CalculateYValue(i);
                newPoint.Length = Length;
                newPoint.Color = Color;

                points.Add(newPoint);
            }

            return points;
        }
    }
}
