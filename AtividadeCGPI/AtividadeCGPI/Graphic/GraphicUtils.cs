using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI.Graphic
{
    public static class GraphicUtils
    {
        public static Pen CreatePenByGraphObject(IGraph graph)
        {
            Pen newPen = new Pen(graph.Color);
            newPen.Width = graph.Length;
            return newPen;
        }

        public static void DrawAllPoints(List<PointGraph> points, Control drawingBase)
        {
            foreach (PointGraph point in points)
            {
                point.Draw(drawingBase);
            }
        }
    }
}
