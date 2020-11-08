using AtividadeCGPI.Graphic;
using AtividadeCGPI.Graphic.Circle;
using AtividadeCGPI.Graphic.Line;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AtividadeCGPI.XML
{
    public class XMLExporter
    {
        public XMLExporter()
        {

        }

        public XDocument ExportObjects(List<IGraph> objects, Control drawingBase)
        {
            XDocument xmlDocument = new XDocument();
            XElement figureElement = new XElement("Figura");

            List<XElement> xmlElemnts = new List<XElement>();

            foreach (var item in objects)
            {
                Type itemType = item.GetType();
                if (itemType == typeof(LineGraph))
                {
                    LineGraph line = item as LineGraph;
                    xmlElemnts.Add(CreateLineElement(line, drawingBase));
                }
                else if (itemType == typeof(CircleGraph))
                {
                    CircleGraph circle = item as CircleGraph;
                    xmlElemnts.Add(CreateCircleElement(circle, drawingBase));
                }
            }

            figureElement.Add(xmlElemnts);
            xmlDocument.Add(figureElement);

            return xmlDocument;
        }

        private XElement CreateLineElement(LineGraph line, Control drawingBase)
        {
            XElement lineElement = new XElement("Reta");

            lineElement.Add(CreatePointElement(line.StartPoint.PositionX / drawingBase.Width, line.StartPoint.PositionY / drawingBase.Height));
            lineElement.Add(CreatePointElement(line.EndPoint.PositionX / drawingBase.Width, line.EndPoint.PositionY / drawingBase.Height));
            lineElement.Add(CreateColorElement(line.Color));

            return lineElement;
        }

        private XElement CreateCircleElement(CircleGraph circle, Control drawingBase)
        {
            XElement circleElement = new XElement("Circulo");

            circleElement.Add(CreatePointElement(circle.CenterPoint.PositionX / drawingBase.Width, circle.CenterPoint.PositionY / drawingBase.Height));
            circleElement.Add(new XElement("Raio", circle.Radius / drawingBase.Width));
            circleElement.Add(CreateColorElement(circle.Color));

            return circleElement;
        }

        private XElement CreatePointElement(double percentageX, double percentageY)
        {
            XElement pointElement = new XElement("Ponto");

            pointElement.Add(new XElement("x", percentageX));
            pointElement.Add(new XElement("y", percentageY));

            return pointElement;
        }

        private XElement CreateColorElement(Color color)
        {
            XElement colorElement = new XElement("Cor");

            colorElement.Add(new XElement("R", color.R));
            colorElement.Add(new XElement("G", color.G));
            colorElement.Add(new XElement("B", color.B));

            return colorElement;
        }
    }
}
