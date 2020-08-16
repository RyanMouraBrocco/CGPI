using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

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


    }
}
