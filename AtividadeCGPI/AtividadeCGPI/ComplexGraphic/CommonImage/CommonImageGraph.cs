using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;
using AtividadeCGPI.Graphic;
using AtividadeCGPI.Graphic.Circle;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Point;

namespace AtividadeCGPI.ComplexGraphic.CommonImage
{
    public class CommonImageGraph : IGraph, IComplexGraph
    {
        private int DefaultLength { get { return 5; } }
        public PointGraph CenterPoint { get; set; }
        public int Length { get; set; }
        public Color Color { get; set; }
        public Color SecondColor { get; set; }
        public int LengthFromCenter { get; set; }

        public CommonImageGraph()
        {
            CenterPoint = new PointGraph();
            LengthFromCenter = 300;
            Length = DefaultLength;
            Color = Color.Black;
        }

        public CommonImageGraph(PointGraph centerPoint, int length, int lengthFromCenter, Color color, Color secondColor)
        {
            CenterPoint = centerPoint;
            Length = length;
            LengthFromCenter = lengthFromCenter;
            Color = color;
            SecondColor = secondColor;
        }

        public void Draw(Control drawingBase)
        {
            List<PointGraph> points = GeneratePoints();
            GraphicUtils.DrawAllCircles(GenerateCircles(points), drawingBase);
            GraphicUtils.DrawAllLines(GenerateLines(points), drawingBase);
        }

        private double GetGoldenRatio()
        {
            return (1 + Math.Sqrt(5)) / 2;
        }

        private List<PointGraph> GeneratePoints()
        {
            List<PointGraph> points = new List<PointGraph>();
            PointGraph centerTopPoint = new PointGraph((int)CenterPoint.PositionX, (int)CenterPoint.PositionY - LengthFromCenter);
            PointGraph centerBottomPoint = new PointGraph((int)CenterPoint.PositionX, (int)CenterPoint.PositionY + LengthFromCenter);
            PointGraph leftTopPoint = new PointGraph((int)CenterPoint.PositionX - (int)(GetGoldenRatio() * 0.5 * LengthFromCenter), (int)CenterPoint.PositionY - (int)(0.5 * LengthFromCenter));
            PointGraph leftBottomPoint = new PointGraph((int)CenterPoint.PositionX - (int)(GetGoldenRatio() * 0.5 * LengthFromCenter), (int)CenterPoint.PositionY + (int)(0.5 * LengthFromCenter));
            PointGraph rightTopPoint = new PointGraph((int)CenterPoint.PositionX + (int)(GetGoldenRatio() * 0.5 * LengthFromCenter), (int)CenterPoint.PositionY - (int)(0.5 * LengthFromCenter));
            PointGraph rightBottomPoint = new PointGraph((int)CenterPoint.PositionX + (int)(GetGoldenRatio() * 0.5 * LengthFromCenter), (int)CenterPoint.PositionY + (int)(0.5 * LengthFromCenter));
            PointGraph rightCenterPoint = new PointGraph((int)CenterPoint.PositionX + (int)(0.55 * LengthFromCenter), (int)CenterPoint.PositionY);
            PointGraph leftCenterPoint = new PointGraph((int)CenterPoint.PositionX - (int)(0.55 * LengthFromCenter), (int)CenterPoint.PositionY);
            PointGraph rightTopCenterPoint = new PointGraph((int)CenterPoint.PositionX + (int)(0.25 * LengthFromCenter), (int)CenterPoint.PositionY - (int)(0.5 * LengthFromCenter));
            PointGraph leftTopCenterPoint = new PointGraph((int)CenterPoint.PositionX - (int)(0.25 * LengthFromCenter), (int)CenterPoint.PositionY - (int)(0.5 * LengthFromCenter));
            PointGraph rightBottomCenterPoint = new PointGraph((int)CenterPoint.PositionX + (int)(0.25 * LengthFromCenter), (int)CenterPoint.PositionY + (int)(0.5 * LengthFromCenter));
            PointGraph leftBottomCenterPoint = new PointGraph((int)CenterPoint.PositionX - (int)(0.25 * LengthFromCenter), (int)CenterPoint.PositionY + (int)(0.5 * LengthFromCenter));

            points.Add(centerTopPoint);
            points.Add(centerBottomPoint);
            points.Add(leftTopPoint);
            points.Add(leftBottomPoint);
            points.Add(rightTopPoint);
            points.Add(rightBottomPoint);
            points.Add(rightCenterPoint);
            points.Add(leftCenterPoint);
            points.Add(rightTopCenterPoint);
            points.Add(leftTopCenterPoint);
            points.Add(rightBottomCenterPoint);
            points.Add(leftBottomCenterPoint);

            return points;
        }

        private List<LineGraph> GenerateLines(List<PointGraph> points)
        {
            List<LineGraph> lines = new List<LineGraph>();

            PointGraph centerTopPoint = points[0];
            PointGraph centerBottomPoint = points[1];
            PointGraph leftTopPoint = points[2];
            PointGraph leftBottomPoint = points[3];
            PointGraph rightTopPoint = points[4];
            PointGraph rightBottomPoint = points[5];
            PointGraph rightCenterPoint = points[6];
            PointGraph leftCenterPoint = points[7];
            PointGraph rightTopCenterPoint = points[8];
            PointGraph leftTopCenterPoint = points[9];
            PointGraph rightBottomCenterPoint = points[10];
            PointGraph leftBottomCenterPoint = points[11];

            LineGraph centerVerticalLine = new LineGraph(centerTopPoint, centerBottomPoint, Length, Color);
            LineGraph leftVerticalLine = new LineGraph(leftTopPoint, leftBottomPoint, Length, Color);
            LineGraph rightVerticalLine = new LineGraph(rightTopPoint, rightBottomPoint, Length, Color);
            LineGraph centerHorizontalLine = new LineGraph(rightCenterPoint, leftCenterPoint, Length, Color);
            LineGraph rigthCenterDiagonal = new LineGraph(rightTopCenterPoint, leftBottomCenterPoint, Length, Color);
            LineGraph leftCenterDiagonal = new LineGraph(leftTopCenterPoint, rightBottomCenterPoint, Length, Color);
            LineGraph topHorizontalLine = new LineGraph(rightTopPoint, leftTopPoint, Length, Color);
            LineGraph bottomHorizontalLine = new LineGraph(rightBottomPoint, leftBottomPoint, Length, Color);
            LineGraph leftTopDiagonalLine = new LineGraph(centerTopPoint, leftTopPoint, Length, Color);
            LineGraph rightTopDiagonalLine = new LineGraph(centerTopPoint, rightTopPoint, Length, Color);
            LineGraph leftBottomDiagonalLine = new LineGraph(centerBottomPoint, leftBottomPoint, Length, Color);
            LineGraph rightBottomDiagonalLine = new LineGraph(centerBottomPoint, rightBottomPoint, Length, Color);
            LineGraph rightTopTriangleDiagonalLine = new LineGraph(centerTopPoint, rightBottomPoint, Length, Color);
            LineGraph leftTopTriangleDiagonalLine = new LineGraph(centerTopPoint, leftBottomPoint, Length, Color);
            LineGraph rightBottomTriangleDiagonalLine = new LineGraph(centerBottomPoint, rightTopPoint, Length, Color);
            LineGraph leftBottomTriangleDiagonalLine = new LineGraph(centerBottomPoint, leftTopPoint, Length, Color);
            LineGraph topRectangleDiagonalLine = new LineGraph(leftTopPoint, rightBottomPoint, Length, Color);
            LineGraph bottomRectangleDiagonalLine = new LineGraph(rightTopPoint, leftBottomPoint, Length, Color);

            lines.Add(centerVerticalLine);
            lines.Add(leftVerticalLine);
            lines.Add(rightVerticalLine);
            lines.Add(topHorizontalLine);
            lines.Add(bottomHorizontalLine);
            lines.Add(leftTopDiagonalLine);
            lines.Add(rightTopDiagonalLine);
            lines.Add(leftBottomDiagonalLine);
            lines.Add(rightBottomDiagonalLine);
            lines.Add(rightTopTriangleDiagonalLine);
            lines.Add(leftTopTriangleDiagonalLine);
            lines.Add(rightBottomTriangleDiagonalLine);
            lines.Add(leftBottomTriangleDiagonalLine);
            lines.Add(topRectangleDiagonalLine);
            lines.Add(bottomRectangleDiagonalLine);
            lines.Add(centerHorizontalLine);
            lines.Add(rigthCenterDiagonal);
            lines.Add(leftCenterDiagonal);

            return lines;
        }

        private List<CircleGraph> GenerateCircles(List<PointGraph> points)
        {
            List<CircleGraph> circles = new List<CircleGraph>();

            PointGraph centerTopPoint = points[0];
            PointGraph centerBottomPoint = points[1];
            PointGraph leftTopPoint = points[2];
            PointGraph leftBottomPoint = points[3];
            PointGraph rightTopPoint = points[4];
            PointGraph rightBottomPoint = points[5];
            PointGraph rightCenterPoint = points[6];
            PointGraph leftCenterPoint = points[7];
            PointGraph rightTopCenterPoint = points[8];
            PointGraph leftTopCenterPoint = points[9];
            PointGraph rightBottomCenterPoint = points[10];
            PointGraph leftBottomCenterPoint = points[11];

            CircleGraph centerCircle = new CircleGraph(CenterPoint, leftCenterPoint, Length, SecondColor);
            CircleGraph rightTopCircle = new CircleGraph(rightTopCenterPoint, rightTopPoint, Length, SecondColor);
            CircleGraph leftTopCircle = new CircleGraph(leftTopCenterPoint, leftTopPoint, Length, SecondColor);
            CircleGraph rightBottomCircle = new CircleGraph(rightBottomCenterPoint, rightBottomPoint, Length, SecondColor);
            CircleGraph leftBottomCircle = new CircleGraph(leftBottomCenterPoint, leftBottomPoint, Length, SecondColor);
            CircleGraph rightCenterCircle = new CircleGraph(rightCenterPoint, CenterPoint, Length, SecondColor);
            CircleGraph leftCenterCircle = new CircleGraph(leftCenterPoint, CenterPoint, Length, SecondColor);

            circles.Add(centerCircle);
            circles.Add(rightTopCircle);
            circles.Add(leftTopCircle);
            circles.Add(rightBottomCircle);
            circles.Add(leftBottomCircle);
            circles.Add(rightCenterCircle);
            circles.Add(leftCenterCircle);

            return circles;
        }

        public List<PointGraph> GetAllPoints()
        {
            List<PointGraph> points = GeneratePoints();
            List<LineGraph> lines = GenerateLines(points);
            List<CircleGraph> circles = GenerateCircles(points);

            foreach (LineGraph line in lines)
            {
                points.AddRange(line.GetAllPoints());
            }

            foreach (CircleGraph circle in circles)
            {
                points.AddRange(circle.GetAllPoints());
            }

            return points;
        }
    }
}