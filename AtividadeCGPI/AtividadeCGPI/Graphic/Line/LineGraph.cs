using AtividadeCGPI.Graphic.Point;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AtividadeCGPI.Graphic.Line
{
    public class LineGraph : Line, IGraph
    {
        private int DefaultLength { get { return 5; } }
        public int Length { get; set; }
        public Color Color { get; set; }

        public LineGraph() : base()
        {
            Length = DefaultLength;
            Color = Color.Black;
        }

        public LineGraph(PointGraph startPoint, PointGraph endPoint) : base(startPoint, endPoint)
        {
            Length = DefaultLength;
            Color = Color.Black;
        }

        public LineGraph(PointGraph startPoint, PointGraph endPoint, int length, Color color)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
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

            PointGraph smallerPoint = GetSmallerPoint();
            PointGraph biggerPoint = GetBiggerPoint();

            if (IsVerticalLine())
            {
                for (int i = (int)smallerPoint.PositionY; i <= (int)biggerPoint.PositionY; i++)
                {
                    PointGraph newPoint = new PointGraph((int)CalculateXValue(i), i);
                    newPoint.Length = Length;
                    newPoint.Color = Color;
                    points.Add(newPoint);
                }
            }
            else
            {
                for (int i = (int)smallerPoint.PositionX; i <= (int)biggerPoint.PositionX; i++)
                {
                    PointGraph newPoint = new PointGraph(i, (int)CalculateYValue(i));
                    newPoint.Length = Length;
                    newPoint.Color = Color;
                    points.Add(newPoint);
                }
            }

            return points;
        }

        private PointGraph GetSmallerPoint()
        {
            if (IsVerticalLine())
            {
                if (StartPoint.PositionY > EndPoint.PositionY)
                {
                    return (PointGraph)EndPoint;
                }
                else
                {
                    return (PointGraph)StartPoint;
                }
            }
            else
            {
                if (StartPoint.PositionX > EndPoint.PositionX)
                {
                    return (PointGraph)EndPoint;
                }
                else
                {
                    return (PointGraph)StartPoint;
                }
            }
        }

        private PointGraph GetBiggerPoint()
        {
            if (IsVerticalLine())
            {
                if (StartPoint.PositionY > EndPoint.PositionY)
                {
                    return (PointGraph)StartPoint;
                }
                else
                {
                    return (PointGraph)EndPoint;
                }
            }
            else
            {
                if (StartPoint.PositionX > EndPoint.PositionX)
                {
                    return (PointGraph)StartPoint;
                }
                else
                {
                    return (PointGraph)EndPoint;
                }
            }
        }

        private bool IsVerticalLine()
        {
            int diffX = (int)(StartPoint.PositionX - EndPoint.PositionX);
            int diffY = (int)(StartPoint.PositionY - EndPoint.PositionY);

            if (diffX < 0)
            {
                diffX = diffX * -1;
            }

            if (diffY < 0)
            {
                diffY = diffY * -1;
            }

            return diffX < diffY;
        }
    }
}
