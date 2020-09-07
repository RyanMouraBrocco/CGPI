using AtividadeCGPI.Graphic;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI.ComplexGraphic.LinesFigure
{
    public class LinesFigureGraph : IGraph, IComplexGraph
    {
        private int DefaultLength { get { return 5; } }
        public PointGraph CenterPoint { get; set; }
        public int DivisionQuantity { get; set; }
        public int Length { get; set; }
        public Color Color { get; set; }
        public int LengthFromCenter { get; set; }

        public LinesFigureGraph()
        {
            CenterPoint = new PointGraph();
            DivisionQuantity = 1;
            Length = DefaultLength;
            LengthFromCenter = 300;
            Color = Color.Black;
        }

        public LinesFigureGraph(PointGraph centerPoint, int divisionQuantity, int length, int lengthFromCenter, Color color)
        {
            CenterPoint = centerPoint;
            DivisionQuantity = divisionQuantity;
            Length = length;
            LengthFromCenter = lengthFromCenter;
            Color = color;
        }

        public void Draw(Control drawingBase)
        {
            GraphicUtils.DrawAllLines(GenerateLines(), drawingBase);
        }

        public List<LineGraph> GenerateLines()
        {
            List<LineGraph> lines = new List<LineGraph>();
            PointGraph leftTopPoint = new PointGraph((int)CenterPoint.PositionX - LengthFromCenter, (int)CenterPoint.PositionY - LengthFromCenter);
            PointGraph rightTopPoint = new PointGraph((int)CenterPoint.PositionX + LengthFromCenter, (int)CenterPoint.PositionY - LengthFromCenter);
            PointGraph leftBottomPoint = new PointGraph((int)CenterPoint.PositionX - LengthFromCenter, (int)CenterPoint.PositionY + LengthFromCenter);
            PointGraph rightBottomPoint = new PointGraph((int)CenterPoint.PositionX + LengthFromCenter, (int)CenterPoint.PositionY + LengthFromCenter);

            lines.Add(new LineGraph(leftTopPoint, rightTopPoint, Length, Color));
            lines.Add(new LineGraph(leftBottomPoint, rightBottomPoint, Length, Color));
            lines.Add(new LineGraph(leftTopPoint, leftBottomPoint, Length, Color));
            lines.Add(new LineGraph(rightTopPoint, rightBottomPoint, Length, Color));

            Graphic.Point.Point currentPoint = null;
            double interval = (double)(2 * LengthFromCenter) / (double)(DivisionQuantity - 1);
            int quantityOfInterval = 1;
            while (!leftTopPoint.Equals(currentPoint))
            {
                if (currentPoint == null)
                    currentPoint = leftTopPoint;

                Graphic.Point.Point nextPoint = new Graphic.Point.Point();
                if (currentPoint.PositionY == leftTopPoint.PositionY && currentPoint.PositionX != rightTopPoint.PositionX)
                {
                    nextPoint.PositionX = rightTopPoint.PositionX;
                    nextPoint.PositionY = rightTopPoint.PositionY + (quantityOfInterval * interval);
                }
                else if (currentPoint.PositionY == leftBottomPoint.PositionY && currentPoint.PositionX != leftBottomPoint.PositionX)
                {
                    nextPoint.PositionX = leftTopPoint.PositionX;
                    nextPoint.PositionY = leftTopPoint.PositionY + ((2 * LengthFromCenter) - (quantityOfInterval * interval));
                }
                else
                {
                    if (currentPoint.PositionX == leftTopPoint.PositionX)
                    {
                        nextPoint.PositionX = leftTopPoint.PositionX + (quantityOfInterval * interval);
                        nextPoint.PositionY = leftTopPoint.PositionY;
                    }
                    else if (currentPoint.PositionX == rightTopPoint.PositionX)
                    {
                        nextPoint.PositionX = rightBottomPoint.PositionX - (quantityOfInterval * interval);
                        nextPoint.PositionY = rightBottomPoint.PositionY;
                    }
                }

                lines.Add(CreateLineByPoint(currentPoint, nextPoint));
                currentPoint = nextPoint;

                quantityOfInterval = IncrementQuantity(quantityOfInterval);
            }

            return lines;
        }

        private int IncrementQuantity(int quantity)
        {
            if (quantity == DivisionQuantity - 1)
            {
                quantity = 1;
            }
            else
            {
                quantity += 1;
            }

            return quantity;
        }

        private LineGraph CreateLineByPoint(Graphic.Point.Point startPoint, Graphic.Point.Point endPoint)
        {
            LineGraph newLine = new LineGraph(new PointGraph((int)startPoint.PositionX, (int)startPoint.PositionY), new PointGraph((int)endPoint.PositionX, (int)endPoint.PositionY), Length, Color);
            return newLine;
        }
    }
}
