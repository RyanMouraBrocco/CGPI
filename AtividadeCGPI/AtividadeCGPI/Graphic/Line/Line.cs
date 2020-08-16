using AtividadeCGPI.Graphic.Point;
using System.Drawing;

namespace AtividadeCGPI.Graphic.Line
{
    public class Line
    {
        public Point.Point StartPoint { get; set; }
        public Point.Point EndPoint { get; set; }

        public Line()
        {
            StartPoint = new Point.Point();
            EndPoint = new Point.Point();
        }

        public Line(Point.Point startPoint, Point.Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Line(double startXPosition, double startYPosition, double endXPosition, double endYPosition)
        {
            StartPoint = new Point.Point(startXPosition, startYPosition);
            EndPoint = new Point.Point(endXPosition, endYPosition);
        }

        private double GenerateSlopeValue()
        {
            if ((StartPoint.PositionX - EndPoint.PositionX) == 0)
            {
                return 0;
            }

            return (StartPoint.PositionY - EndPoint.PositionY) / (StartPoint.PositionX - EndPoint.PositionX);
        }

        private double GenerateConstantValue()
        {
            double slopeIndex = GenerateSlopeValue();
            return StartPoint.PositionY - (slopeIndex * StartPoint.PositionX);
        }

        protected double CalculateYValue(double positionX)
        {
            return (GenerateSlopeValue() * positionX) + GenerateConstantValue();
        }

        protected double CalculateXValue(double positionY)
        {
            double slopeIndex = GenerateSlopeValue();

            if (slopeIndex == 0)
            {
                return 0;
            }

            return (positionY - GenerateConstantValue()) / slopeIndex;
        }

    }
}
