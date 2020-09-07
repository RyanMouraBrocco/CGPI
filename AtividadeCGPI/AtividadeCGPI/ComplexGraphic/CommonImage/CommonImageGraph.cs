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
        public int LengthFromCenter { get; set; }

        public CommonImageGraph()
        {
            CenterPoint = new PointGraph();
            LengthFromCenter = 300;
            Length = DefaultLength;
            Color = Color.Black;
        }

        public CommonImageGraph(PointGraph centerPoint, int length,int lengthFromCenter, Color color)
        {
            CenterPoint = centerPoint;
            Length = length;
            LengthFromCenter = lengthFromCenter;
            Color = color;
        }

        public void Draw(Control drawingBase)
        {
            List<LineGraph> lines = new List<LineGraph>();

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

            LineGraph centerVerticalLine = new LineGraph(centerTopPoint, centerBottomPoint, Length, Color.Red);
            LineGraph leftVerticalLine = new LineGraph(leftTopPoint, leftBottomPoint, Length, Color.Red);
            LineGraph rightVerticalLine = new LineGraph(rightTopPoint, rightBottomPoint, Length, Color.Red);
            LineGraph centerHorizontalLine = new LineGraph(rightCenterPoint, leftCenterPoint, Length, Color.Red);
            LineGraph rigthCenterDiagonal = new LineGraph(rightTopCenterPoint, leftBottomCenterPoint, Length, Color.Red);
            LineGraph leftCenterDiagonal = new LineGraph(leftTopCenterPoint, rightBottomCenterPoint, Length, Color.Red);
            LineGraph topHorizontalLine = new LineGraph(rightTopPoint, leftTopPoint, Length, Color.Red);
            LineGraph bottomHorizontalLine = new LineGraph(rightBottomPoint, leftBottomPoint, Length, Color.Red);
            LineGraph leftTopDiagonalLine = new LineGraph(centerTopPoint, leftTopPoint, Length, Color.Red);
            LineGraph rightTopDiagonalLine = new LineGraph(centerTopPoint, rightTopPoint, Length, Color.Red);
            LineGraph leftBottomDiagonalLine = new LineGraph(centerBottomPoint, leftBottomPoint, Length, Color.Red);
            LineGraph rightBottomDiagonalLine = new LineGraph(centerBottomPoint, rightBottomPoint, Length, Color.Red);
            LineGraph rightTopTriangleDiagonalLine = new LineGraph(centerTopPoint, rightBottomPoint, Length, Color.Red);
            LineGraph leftTopTriangleDiagonalLine = new LineGraph(centerTopPoint, leftBottomPoint, Length, Color.Red);
            LineGraph rightBottomTriangleDiagonalLine = new LineGraph(centerBottomPoint, rightTopPoint, Length, Color.Red);
            LineGraph leftBottomTriangleDiagonalLine = new LineGraph(centerBottomPoint, leftTopPoint, Length, Color.Red);
            LineGraph topRectangleDiagonalLine = new LineGraph(leftTopPoint, rightBottomPoint, Length, Color.Red);
            LineGraph bottomRectangleDiagonalLine = new LineGraph(rightTopPoint, leftBottomPoint, Length, Color.Red);

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

            List<CircleGraph> circles = new List<CircleGraph>();

            CircleGraph centerCircle = new CircleGraph(CenterPoint, leftCenterPoint, Length, Color.Green);
            CircleGraph rightTopCircle = new CircleGraph(rightTopCenterPoint, rightTopPoint, Length, Color.Green);
            CircleGraph leftTopCircle = new CircleGraph(leftTopCenterPoint, leftTopPoint, Length, Color.Green);
            CircleGraph rightBottomCircle = new CircleGraph(rightBottomCenterPoint, rightBottomPoint, Length, Color.Green);
            CircleGraph leftBottomCircle = new CircleGraph(leftBottomCenterPoint, leftBottomPoint, Length, Color.Green);
            CircleGraph rightCenterCircle = new CircleGraph(rightCenterPoint, CenterPoint, Length, Color.Green);
            CircleGraph leftCenterCircle = new CircleGraph(leftCenterPoint, CenterPoint, Length, Color.Green);

            circles.Add(centerCircle);
            circles.Add(rightTopCircle);
            circles.Add(leftTopCircle);
            circles.Add(rightBottomCircle);
            circles.Add(leftBottomCircle);
            circles.Add(rightCenterCircle);
            circles.Add(leftCenterCircle);

            GraphicUtils.DrawAllCircles(circles, drawingBase);
            GraphicUtils.DrawAllLines(lines, drawingBase);
        }

        private double GetGoldenRatio()
        {
            return (1 + Math.Sqrt(5)) / 2;
        }
    }
}