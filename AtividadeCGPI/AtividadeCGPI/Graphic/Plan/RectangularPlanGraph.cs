using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI.Graphic.Plan
{
    public class RectangularPlanGraph : RectangularPlan, IGraph
    {
        public int Length { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public RectangularPlanGraph(PointGraph initialPoint, PointGraph finalPoint) : base(initialPoint, finalPoint)
        {
            Size = new Size((int)(finalPoint.PositionX - initialPoint.PositionX), (int)(finalPoint.PositionY - initialPoint.PositionY));
        }

        public void Draw(Control drawingBase)
        {
            GraphicUtils.DrawAllPoints(GetAllPoints(), drawingBase);
        }

        public List<PointGraph> GetAllPoints()
        {
            List<PointGraph> allPoints = new List<PointGraph>();
            for (int i = (int)InitialPoint.PositionX; i <= (int)FinalPoint.PositionX; i++)
            {
                for (int j = (int)InitialPoint.PositionY; j <= (int)FinalPoint.PositionY; j++)
                {
                    allPoints.Add(new PointGraph(i, j));
                }
            }

            return allPoints;
        }
    }
}
