using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI.Graphic.Point
{
    public class PointGraph : Point, IGraph, ICloneable
    {
        private int DefaultLength { get { return 5; } }
        public int Length { get; set; }
        public Color Color { get; set; }

        public PointGraph() : base()
        {
            Length = DefaultLength;
            Color = Color.Black;
        }

        public PointGraph(int x, int y) : base(x, y)
        {
            Color = Color.Black;
            Length = DefaultLength;
        }

        public PointGraph(int x, int y, Color color, int length)
        {
            PositionX = x;
            PositionY = y;
            Color = color;
            Length = length;
        }

        public void Draw(Control drawingBase)
        {
            System.Drawing.Point drawingPoint = PointGraphToMicrosoftPoint(this);
            Pen pen = GraphicUtils.CreatePenByGraphObject(this);
            drawingBase.CreateGraphics().FillRectangle(pen.Brush, new Rectangle(drawingPoint, new Size(Length, Length)));
        }

        public static System.Drawing.Point PointGraphToMicrosoftPoint(Point point)
        {
            System.Drawing.Point microsoftPoint = new System.Drawing.Point();
            microsoftPoint.X = (int)point.PositionX;
            microsoftPoint.Y = (int)point.PositionY;

            return microsoftPoint;
        }

        public object Clone()
        {
            PointGraph clonedObject = new PointGraph();
            clonedObject.PositionX = this.PositionX;
            clonedObject.PositionY = this.PositionY;
            clonedObject.Length = this.Length;
            clonedObject.Color = this.Color;

            return clonedObject;
        }
    }
}
