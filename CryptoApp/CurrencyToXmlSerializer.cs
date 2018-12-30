using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CryptoApp
{
    public class CurrencyToXmlSerializer
    {
        public void SerializeToStream(Currency curr, FileStream stream)
        {
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));

            var root = doc.CreateElement("Currency");
            var codeNode = doc.CreateElement("Code");
            codeNode.InnerText = curr.Name;

            var dateNode = doc.CreateElement("Date");
            dateNode.InnerText = DateTime.Now.ToString();

            doc.AppendChild(root);
            root.AppendChild(codeNode);
            root.AppendChild(dateNode);

            var type = curr.GetType();
            var props = type.GetProperties();

            var ratesNode = doc.CreateElement("Rates");
            foreach (var prop in props)
            {
                if (prop.Name == "Name")
                {
                    continue;
                }

                var propNode = doc.CreateElement(prop.Name);
                propNode.InnerText = prop.GetValue(curr).ToString();

                ratesNode.AppendChild(propNode);

            }

            root.AppendChild(ratesNode);

            doc.Save(stream);
        }
    }
}
