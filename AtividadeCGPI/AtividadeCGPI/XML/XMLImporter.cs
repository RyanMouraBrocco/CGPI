using AtividadeCGPI.Graphic;
using AtividadeCGPI.Graphic.Circle;
using AtividadeCGPI.Graphic.Line;
using AtividadeCGPI.Graphic.Point;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AtividadeCGPI.XML
{
    public class XMLImporter
    {
        private XDocument Xml { get; set; }

        public XMLImporter(string filePath)
        {
            Xml = XDocument.Load(filePath);
        }

        public List<IGraph> ImporterObjects(Control drawingBase)
        {
            dynamic linesItems = GetLines();
            List<IGraph> graphs = new List<IGraph>();
            List<LineGraph> lines = new List<LineGraph>();

            foreach (var item in linesItems)
            {
                LineGraph newLine = new LineGraph();
                newLine.Color = Color.FromArgb(item.color.red, item.color.green, item.color.blue);
                newLine.StartPoint = new PointGraph(GetBrutePosition(item.startPoint.x, drawingBase.Width), GetBrutePosition(item.startPoint.y, drawingBase.Height));
                newLine.EndPoint = new PointGraph(GetBrutePosition(item.endPoint.x, drawingBase.Width), GetBrutePosition(item.endPoint.y, drawingBase.Height));
                lines.Add(newLine);
            }

            graphs.AddRange(lines);

            dynamic circleItems = GetCircles();
            List<CircleGraph> circles = new List<CircleGraph>();
            foreach (var item in circleItems)
            {
                CircleGraph newCircle = new CircleGraph();
                newCircle.Color = Color.FromArgb(item.color.red, item.color.green, item.color.blue);
                int bruteYPosition = GetBrutePosition(item.centerPoint.y, drawingBase.Height);
                int bruteXPosition = GetBrutePosition(item.centerPoint.x, drawingBase.Width);
                newCircle.CenterPoint = new PointGraph(bruteXPosition, bruteYPosition);
                int bruteRadius = GetBrutePosition(item.radius, drawingBase.Width);
                newCircle.ExtremePoint = new PointGraph(bruteXPosition + bruteRadius, bruteYPosition);
                circles.Add(newCircle);
            }

            graphs.AddRange(circles);

            return graphs;
        }

        private object GetLines()
        {
            return Xml.Element("Figura").Elements("Reta")
                .Select(x =>
                    new
                    {
                        startPoint = new
                        {
                            x = double.Parse(x.Element("Ponto").Element("x").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            y = double.Parse(x.Element("Ponto").Element("y").Value, NumberStyles.Float, new CultureInfo("en-US"))
                        },
                        endPoint = new
                        {
                            x = double.Parse(x.Elements("Ponto").Last().Element("x").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            y = double.Parse(x.Elements("Ponto").Last().Element("y").Value, NumberStyles.Float, new CultureInfo("en-US"))
                        },
                        color = new
                        {
                            red = int.Parse(x.Element("Cor").Element("R").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            green = int.Parse(x.Element("Cor").Element("G").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            blue = int.Parse(x.Element("Cor").Element("B").Value, NumberStyles.Float, new CultureInfo("en-US")),
                        }
                    });
        }

        private object GetCircles()
        {
            return Xml.Element("Figura").Elements("Circulo")
                .Select(x =>
                    new
                    {
                        centerPoint = new
                        {
                            x = double.Parse(x.Element("Ponto").Element("x").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            y = double.Parse(x.Element("Ponto").Element("y").Value, NumberStyles.Float, new CultureInfo("en-US"))
                        },
                        radius = double.Parse(x.Element("Raio").Value, NumberStyles.Float, new CultureInfo("en-US")),
                        color = new
                        {
                            red = int.Parse(x.Element("Cor").Element("R").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            green = int.Parse(x.Element("Cor").Element("G").Value, NumberStyles.Float, new CultureInfo("en-US")),
                            blue = int.Parse(x.Element("Cor").Element("B").Value, NumberStyles.Float, new CultureInfo("en-US")),
                        }
                    });
        }

        private int GetBrutePosition(double relativePosition, int drawingBaseLength)
        {
            return (int)(relativePosition * drawingBaseLength);
        }
    }
}
