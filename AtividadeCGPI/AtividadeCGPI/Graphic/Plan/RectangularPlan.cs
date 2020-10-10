using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AtividadeCGPI.Graphic.Plan
{
    public class RectangularPlan
    {
        public Point.Point InitialPoint { get; set; }
        public Point.Point FinalPoint { get; set; }

        public RectangularPlan(Point.Point pointA, Point.Point pointB)
        {
            if (pointA.PositionX == pointB.PositionX || pointA.PositionY == pointB.PositionY)
            {
                throw new Exception("Invalid Points");
            }

            double smallestX = pointA.PositionX < pointB.PositionX ? pointA.PositionX : pointB.PositionX;
            double biggestY = pointA.PositionY > pointB.PositionY ? pointA.PositionY : pointB.PositionY;

            InitialPoint = new Point.Point(smallestX, biggestY);

            double biggestX = pointA.PositionX > pointB.PositionX ? pointA.PositionX : pointB.PositionX;
            double smallestY = pointA.PositionY < pointB.PositionY ? pointA.PositionY : pointB.PositionY;

            FinalPoint = new Point.Point(biggestX, smallestY);
        }
    }
}
