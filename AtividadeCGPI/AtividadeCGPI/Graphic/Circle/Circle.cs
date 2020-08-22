using System;
using System.Collections.Generic;
using System.Text;
using AtividadeCGPI.Graphic.Point;

namespace AtividadeCGPI.Graphic.Circle
{
    public class Circle
    {
        private Point.Point centerPoint;
        private Point.Point extremePoint;
        public Point.Point CenterPoint
        {
            get
            {
                return centerPoint;
            }
            set
            {
                centerPoint = value;
                Radius = CalculateRadius();
            }
        }

        public Point.Point ExtremePoint
        {
            get
            {
                return extremePoint;
            }
            set
            {
                extremePoint = value;
                Radius = CalculateRadius();
            }
        }
        public double Radius { get; private set; }

        public Circle()
        {
            CenterPoint = new Point.Point();
            ExtremePoint = new Point.Point();
        }

        public Circle(Point.Point centerPoint, Point.Point extremePoint)
        {
            CenterPoint = centerPoint;
            ExtremePoint = extremePoint;
        }

        private double CalculateRadius()
        {
            if (ExtremePoint == null || CenterPoint == null)
            {
                return 0;
            }

            double diffX = ExtremePoint.PositionX - CenterPoint.PositionX;
            double diffY = ExtremePoint.PositionY - CenterPoint.PositionY;

            return Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        }

        protected double CalculateXValue(double angle)
        {
            return CenterPoint.PositionX + (Radius * Math.Cos(angle));
        }

        protected double CalculateYValue(double angle)
        {
            return CenterPoint.PositionY + (Radius * Math.Sin(angle));
        }

    }
}
