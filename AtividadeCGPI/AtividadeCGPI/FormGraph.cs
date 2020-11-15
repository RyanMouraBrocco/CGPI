using System.Windows.Forms;
using AtividadeCGPI.Graphic.Point;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Circle;
using System.Drawing;
using AtividadeCGPI.Mapping;
using System.Collections.Generic;
using AtividadeCGPI.Graphic.Plan;
using AtividadeCGPI.Graphic;
using System;
using System.IO;
using AtividadeCGPI.XML;
using System.Linq;

namespace AtividadeCGPI
{
    public partial class FormGraph : Form
    {
        private PointGraph startPoint;
        private int state = 0;
        private Color color;
        private bool mapping = false;
        private Stack<IGraph> drawedGraphs;
        private Stack<IGraph> deletedGraphs;
        private RectangularPlanGraph drawingBase;
        private RectangularPlanGraph viewBase;

        public FormGraph()
        {
            InitializeComponent();
            drawedGraphs = new Stack<IGraph>();
            deletedGraphs = new Stack<IGraph>();
            drawingBase = new RectangularPlanGraph(new PointGraph(), new PointGraph(this.Width, this.Height));
            viewBase = new RectangularPlanGraph(new PointGraph(), new PointGraph(mapppedPanel.Width, mapppedPanel.Height));
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
                GraphicUtils.DrawAllPoints(mapper.FinalPoints, mapppedPanel);
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
            mapppedPanel.Invalidate();
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
                mapppedPanel.Visible = false;
            }
            else
            {
                mapping = true;
                mapppedPanel.Visible = true;
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
                    GraphicUtils.EraseGraph(point, mapppedPanel.BackColor, mapppedPanel);
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
                    point.Draw(mapppedPanel);
                }
            }
        }

        private void btnImporter_Click(object sender, System.EventArgs e)
        {
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.Equals(Path.GetExtension(openFileDialog.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        XMLImporter importer = new XMLImporter(openFileDialog.FileName);
                        List<IGraph> importedObjects = importer.ImporterObjects(this);
                        foreach (var item in importedObjects)
                        {
                            item.Draw(this);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Arquivo não contem definições corretas", "Erro na importação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Formato do arquivo inválido", "Erro na importação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExporter_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XMLExporter exporter = new XMLExporter();
                File.WriteAllText(saveFileDialog.FileName, exporter.ExportObjects(drawedGraphs.ToList(), this).ToString());
            }
        }
    }
}
