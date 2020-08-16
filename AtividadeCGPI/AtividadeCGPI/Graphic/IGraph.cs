using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeCGPI.Graphic
{
    public interface IGraph
    {
        int Length { get; set; }
        Color Color { get; set; }

        void Draw(Control drawingBase);
    }
}
