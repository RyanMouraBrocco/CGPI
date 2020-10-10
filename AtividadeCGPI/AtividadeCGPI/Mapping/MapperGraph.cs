using AtividadeCGPI.Graphic.Plan;
using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;

namespace AtividadeCGPI.Mapping
{
    public class MapperGraph
    {
        public List<PointGraph> OriginalPoints { get; set; }
        public RectangularPlanGraph OriginalArea { get; set; }
        public List<PointGraph> FinalPoints { get; private set; }
        public RectangularPlanGraph FinalArea { get; set; }

        public MapperGraph(List<PointGraph> originalPoints, RectangularPlanGraph originalArea, RectangularPlanGraph finalArea)
        {
            OriginalPoints = originalPoints;
            FinalPoints = new List<PointGraph>();
            OriginalArea = originalArea;
            FinalArea = finalArea;
        }

        public void Map()
        {
            foreach (PointGraph point in OriginalPoints)
            {
                double percentageX = (point.PositionX - OriginalArea.InitialPoint.PositionX) / OriginalArea.Size.Width;
                double percentageY = (point.PositionY - OriginalArea.InitialPoint.PositionY) / OriginalArea.Size.Height;

                int mappedX = (int)(FinalArea.InitialPoint.PositionX + (percentageX * FinalArea.Size.Width));
                int mappedY = (int)(FinalArea.InitialPoint.PositionY + (percentageY * FinalArea.Size.Height));

                double areaScale = (double)(FinalArea.Size.Width * FinalArea.Size.Height) / (double)(OriginalArea.Size.Width * OriginalArea.Size.Height);

                PointGraph finalPoint = new PointGraph(mappedX, mappedY, point.Color, (int)(point.Length * areaScale));
                FinalPoints.Add(finalPoint);
            }
        }
    }
}
