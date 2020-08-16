﻿using System.Windows.Forms;
using AtividadeCGPI.Graphic.Point;
using AtividadeCGPI.Graphic.Line;

namespace AtividadeCGPI
{
    public partial class Form1 : Form
    {
        private PointGraph startPoint;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (startPoint == null)
            {
                PointGraph newPoint = new PointGraph(e.X, e.Y);
                newPoint.Draw(this);
                startPoint = newPoint;
            }
            else
            {
                PointGraph newPoint = new PointGraph(e.X, e.Y);
                LineGraph newLine = new LineGraph(startPoint, newPoint);
                newLine.Draw(this);
                startPoint = null;
            }
        }
    }
}