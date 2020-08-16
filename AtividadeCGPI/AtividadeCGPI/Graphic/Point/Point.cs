using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeCGPI.Graphic.Point
{
    public class Point
    {
        public double PositionX { get; set; }
        public double PositionY { get; set; }

        public Point()
        {
            PositionX = 0;
            PositionY = 0;
        }

        public Point(double x, double y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
