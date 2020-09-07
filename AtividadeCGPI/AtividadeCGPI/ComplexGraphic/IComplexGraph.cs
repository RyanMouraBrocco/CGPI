using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeCGPI.ComplexGraphic
{
    public interface IComplexGraph
    {
        PointGraph CenterPoint { get; set; }
        int LengthFromCenter { get; set; }
    }
}
