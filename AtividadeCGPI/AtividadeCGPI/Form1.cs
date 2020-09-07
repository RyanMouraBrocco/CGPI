using System.Windows.Forms;
using AtividadeCGPI.Graphic.Point;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Circle;
using System.Drawing;
using AtividadeCGPI.ComplexGraphic.CommonImage;
using AtividadeCGPI.ComplexGraphic.LinesFigure;

namespace AtividadeCGPI
{
    public partial class Form1 : Form
    {
        private PointGraph startPoint;
        private int state = 0;
        private Color color;
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
                newPoint.Color = color;
                if (state != 3)
                {
                    newPoint.Draw(this);
                    startPoint = newPoint;
                }
                else
                {
                    //CommonImageGraph commonImage = new CommonImageGraph(newPoint, 5, color);
                    //commonImage.Draw(this);
                    LinesFigureGraph linesFigure = new LinesFigureGraph(newPoint, 5, 5, 300, color);
                    linesFigure.Draw(this);
                }
            }
            else
            {
                PointGraph newPoint = new PointGraph(e.X, e.Y);
                switch (state)
                {
                    case 0:
                        newPoint.Color = color;
                        newPoint.Draw(this);
                        break;
                    case 1:
                        LineGraph newLine = new LineGraph(startPoint, newPoint);
                        newLine.Color = color;
                        newLine.Draw(this);
                        break;
                    case 2:
                        CircleGraph newCirle = new CircleGraph(startPoint, newPoint);
                        newCirle.Color = color;
                        newCirle.Draw(this);
                        break;
                    default:
                        break;
                }


                startPoint = null;
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            color = Color.Black;
            panelColor.BackColor = Color.Black;
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            this.Invalidate();
            startPoint = null;
        }

        private void btnPoint_Click(object sender, System.EventArgs e)
        {
            state = 0;
            startPoint = null;
        }

        private void btnLine_Click(object sender, System.EventArgs e)
        {
            state = 1;
            startPoint = null;
        }

        private void btnCircle_Click(object sender, System.EventArgs e)
        {
            state = 2;
            startPoint = null;
        }

        private void btnCommon_Click(object sender, System.EventArgs e)
        {
            FormComplexGraph complexForm = new FormComplexGraph();
            complexForm.ShowDialog();
        }

        private void linkColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                color = colorDialog1.Color;
                panelColor.BackColor = color;
            }
        }
    }
}
