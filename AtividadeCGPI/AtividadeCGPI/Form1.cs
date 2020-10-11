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
        private bool mapping = false;
        private Stack<IGraph> drawedGraphs;
        private Stack<IGraph> deletedGraphs;
        private RectangularPlanGraph drawingBase;
        private RectangularPlanGraph viewBase;

        public Form1()
        {
            InitializeComponent();
            drawedGraphs = new Stack<IGraph>();
            deletedGraphs = new Stack<IGraph>();
            drawingBase = new RectangularPlanGraph(new PointGraph(), new PointGraph(this.Width, this.Height));
            viewBase = new RectangularPlanGraph(new PointGraph(), new PointGraph(panel2.Width, panel2.Height));
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            List<PointGraph> points = new List<PointGraph>();
            if (startPoint == null)
            {
                PointGraph newPoint = new PointGraph(e.X, e.Y);
                newPoint.Color = color;
                startPoint = newPoint;

                if (state == 0)
                {
                    newPoint.Draw(this);
                    points.Add(newPoint);
                    drawedGraphs.Push(newPoint);
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
                        points.Add(newPoint);
                        drawedGraphs.Push(newPoint);
                        break;
                    case 1:
                        LineGraph newLine = new LineGraph(startPoint, newPoint);
                        newLine.Color = color;
                        newLine.Draw(this);
                        points.AddRange(newLine.GetAllPoints());
                        drawedGraphs.Push(newLine);
                        break;
                    case 2:
                        CircleGraph newCirle = new CircleGraph(startPoint, newPoint);
                        newCirle.Color = color;
                        newCirle.Draw(this);
                        points.AddRange(newCirle.GetAllPoints());
                        drawedGraphs.Push(newCirle);
                        break;
                    default:
                        break;
                }

                startPoint = null;
            }

            if (mapping)
            {
                MapperGraph mapper = new MapperGraph(points, drawingBase, viewBase);
                mapper.Map();
                GraphicUtils.DrawAllPoints(mapper.FinalPoints, panel2);
            }

            btnDelete.Enabled = true;
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
            btnRedraw.Enabled = false;
            btnDelete.Enabled = false;
            deletedGraphs.Clear();
            drawedGraphs.Clear();
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

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            IGraph deletedItem = drawedGraphs.Pop();
            GraphicUtils.EraseGraph(deletedItem, this.BackColor, this);
            deletedGraphs.Push(deletedItem);
            btnRedraw.Enabled = true;

            if (drawedGraphs.Count == 0)
            {
                btnDelete.Enabled = false;
            }

            if (mapping)
            {
                MapperGraph mapper = new MapperGraph(deletedItem.GetAllPoints(), drawingBase, viewBase);
                mapper.Map();
                foreach (PointGraph point in mapper.FinalPoints)
                {
                    GraphicUtils.EraseGraph(point, panel2.BackColor, panel2);
                }
            }
        }

        private void btnRedraw_Click(object sender, System.EventArgs e)
        {
            IGraph redrawedItem = deletedGraphs.Pop();
            drawedGraphs.Push(redrawedItem);
            redrawedItem.Draw(this);
            btnDelete.Enabled = true;

            if (deletedGraphs.Count == 0)
            {
                btnRedraw.Enabled = false;
            }

            if (mapping)
            {
                MapperGraph mapper = new MapperGraph(redrawedItem.GetAllPoints(), drawingBase, viewBase);
                mapper.Map();
                foreach (PointGraph point in mapper.FinalPoints)
                {
                    point.Draw(panel2);
                }
            }
        }
    }
}
