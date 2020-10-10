using Accessibility;
using AtividadeCGPI.Graphic;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            if (DivisionQuantity > 1)
            {
                Graphic.Point.Point currentPoint = null;
                Graphic.Point.Point initialPoint = (Graphic.Point.Point)leftTopPoint.Clone();


                if (DivisionQuantity % 2 == 0)
                {
                    lines.AddRange(GenerateLines(initialPoint, currentPoint, leftTopPoint, rightTopPoint, leftBottomPoint, rightBottomPoint, 1));
                }
                else
                {
                    int firstPrimeNumber = GetFirstPrimeDivisionNumber();
                    for (int i = 0; i <= DivisionQuantity;)
                    {
                        double interval = (double)(2 * LengthFromCenter) / (double)(DivisionQuantity);
                        initialPoint.PositionX = leftTopPoint.PositionX + (i * interval);
                        int currentQuantityOfInterval = i < DivisionQuantity ? (i + 1) : 1;

                        lines.AddRange(GenerateLines(initialPoint, currentPoint, leftTopPoint, rightTopPoint, leftBottomPoint, rightBottomPoint, currentQuantityOfInterval));
                        currentPoint = null;

                        if (firstPrimeNumber == DivisionQuantity)
                        {
                            i++;
                        }
                        else
                        {
                            i += (DivisionQuantity / firstPrimeNumber);
                        }
                    }
                }

            }
            else
            {
                lines.Add(new LineGraph(leftTopPoint, rightBottomPoint, Length, Color));
                lines.Add(new LineGraph(rightTopPoint, leftBottomPoint, Length, Color));
            }

            return lines;
        }

        private int IncrementQuantity(int quantity)
        {
            if (quantity == DivisionQuantity)
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

        private List<LineGraph> GenerateLines(Graphic.Point.Point initialPoint, Graphic.Point.Point currentPoint, PointGraph leftTopPoint, PointGraph rightTopPoint, PointGraph leftBottomPoint, PointGraph rightBottomPoint, int initialInterval)
        {
            List<LineGraph> lines = new List<LineGraph>();
            int quantityOfInterval = initialInterval;
            double interval = (double)(2 * LengthFromCenter) / (double)(DivisionQuantity);

            while (!initialPoint.Equals(currentPoint))
            {
                if (currentPoint == null)
                    currentPoint = initialPoint;

                Graphic.Point.Point nextPoint = new Graphic.Point.Point();
                if (currentPoint.PositionY == leftTopPoint.PositionY && currentPoint.PositionX != rightTopPoint.PositionX)
                {
                    nextPoint.PositionX = rightTopPoint.PositionX;
                    nextPoint.PositionY = quantityOfInterval == DivisionQuantity ? rightBottomPoint.PositionY : rightTopPoint.PositionY + (quantityOfInterval * interval);
                }
                else if (currentPoint.PositionY == leftBottomPoint.PositionY && currentPoint.PositionX != leftBottomPoint.PositionX)
                {
                    nextPoint.PositionX = leftTopPoint.PositionX;
                    nextPoint.PositionY = quantityOfInterval == DivisionQuantity ? leftTopPoint.PositionY : leftTopPoint.PositionY + ((2 * LengthFromCenter) - (quantityOfInterval * interval));
                }
                else
                {
                    if (currentPoint.PositionX == leftTopPoint.PositionX)
                    {
                        nextPoint.PositionX = quantityOfInterval == DivisionQuantity ? rightTopPoint.PositionX : leftTopPoint.PositionX + (quantityOfInterval * interval);
                        nextPoint.PositionY = leftTopPoint.PositionY;
                    }
                    else if (currentPoint.PositionX == rightTopPoint.PositionX)
                    {
                        nextPoint.PositionX = quantityOfInterval == DivisionQuantity ? leftBottomPoint.PositionX : rightBottomPoint.PositionX - (quantityOfInterval * interval);
                        nextPoint.PositionY = rightBottomPoint.PositionY;
                    }
                }

                lines.Add(CreateLineByPoint(currentPoint, nextPoint));
                currentPoint = nextPoint;

                quantityOfInterval = IncrementQuantity(quantityOfInterval);
            }

            return lines;
        }

        private int GetFirstPrimeDivisionNumber()
        {
            int sqrtDivisionNumber = (int)Math.Sqrt(DivisionQuantity);
            for (int i = 3; i <= sqrtDivisionNumber; i += 2)
            {
                if (DivisionQuantity % i == 0)
                {
                    return i;
                }
            }

            return DivisionQuantity;
        }

        public List<PointGraph> GetAllPoints()
        {
            List<PointGraph> allPoints = new List<PointGraph>();
            foreach (LineGraph line in GenerateLines().Distinct())
            {
                allPoints.AddRange(line.GetAllPoints());
            }

            return allPoints;
        }
    }
}
