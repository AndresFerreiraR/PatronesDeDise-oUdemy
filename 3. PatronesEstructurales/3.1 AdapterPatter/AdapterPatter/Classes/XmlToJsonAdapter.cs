using AdapterPatter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatter.Classes
{
    public class XmlToJsonAdapter : IXmlToJson
    {
        private XmlConverter _converter;

        public XmlToJsonAdapter(XmlConverter converter)
        {
            _converter = converter;
        }

        public void ConvertXmlToJson()
        {
            var produtos = _converter.GetXml()
                .Element("Productos")
                .Elements("Producto")
                .Select(x => new Product
                {
                    name = x.Attribute("Nombre").Value,
                    price = int.Parse(x.Attribute("Precio").Value),
                });

            new JsonConverter(produtos.ToList()).ConvertToJson();
        }
    }
}
