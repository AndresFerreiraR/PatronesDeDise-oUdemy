using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterPatter.Classes
{
    public class XmlConverter
    {
        public XDocument GetXml()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Productos");
            var xAttributes = ProductDataProvider.GetData()
                .Select(m => new XElement("Producto", new XAttribute("Nombre", m.name), new XAttribute("Precio", m.price)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }
}
