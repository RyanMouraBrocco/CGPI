using AtividadeCGPI.Graphic.Circle;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public static void DrawAllLines(List<LineGraph> lines, Control drawingBase)
        {
            foreach (LineGraph line in lines.Distinct())
            {
                line.Draw(drawingBase);
            }
        }

        public static void DrawAllCircles(List<CircleGraph> circles, Control drawingBase)
        {
            foreach (CircleGraph circle in circles)
            {
                circle.Draw(drawingBase);
            }
        }
    }
}
