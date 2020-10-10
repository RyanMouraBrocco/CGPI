using System.Windows.Forms;
using AtividadeCGPI.Graphic.Point;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Circle;
using System.Drawing;
using AtividadeCGPI.ComplexGraphic.CommonImage;
using AtividadeCGPI.ComplexGraphic.LinesFigure;
using AtividadeCGPI.Mapping;
using System.Collections.Generic;
using AtividadeCGPI.Graphic.Plan;
using AtividadeCGPI.Graphic;

namespace AtividadeCGPI
{
    public partial class Form1 : Form
    {
        private PointGraph startPoint;
        private int state = 0;
        private Color color;
        bool mapping = false;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            List<PointGraph> points = new List<PointGraph>();
            if (startPoint == null)
            {
                PointGraph newPoint = new PointGraph(e.X, e.Y);
                newPoint.Color = color;
                newPoint.Draw(this);
                startPoint = newPoint;
                points.Add(newPoint);
            }
            else
            {
                PointGraph newPoint = new PointGraph(e.X, e.Y);
                switch (state)
                {
                    case 0:
                        newPoint.Color = color;
                        newPoint.Draw(this);
                        points.Add(newPoint);
                        break;
                    case 1:
                        LineGraph newLine = new LineGraph(startPoint, newPoint);
                        newLine.Color = color;
                        newLine.Draw(this);
                        points.AddRange(newLine.GetAllPoints());
                        break;
                    case 2:
                        CircleGraph newCirle = new CircleGraph(startPoint, newPoint);
                        newCirle.Color = color;
                        newCirle.Draw(this);
                        points.AddRange(newCirle.GetAllPoints());
                        break;
                    default:
                        break;
                }

                startPoint = null;
            }

            if (mapping)
            {
                RectangularPlanGraph drawingBase = new RectangularPlanGraph(new PointGraph(), new PointGraph(this.Width, this.Height));
                RectangularPlanGraph viewBase = new RectangularPlanGraph(new PointGraph(), new PointGraph(panel2.Width, panel2.Height));
                MapperGraph mapper = new MapperGraph(points, drawingBase, viewBase);
                mapper.Map();
                GraphicUtils.DrawAllPoints(mapper.FinalPoints, panel2);
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
            panel2.Invalidate();
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

        private void btnMapping_Click(object sender, System.EventArgs e)
        {
            if (mapping)
            {
                mapping = false;
                panel2.Visible = false;
            }
            else
            {
                mapping = true;
                panel2.Visible = true;
            }
        }
    }
}
