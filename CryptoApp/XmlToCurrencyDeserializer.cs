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
    public class XmlToCurrencyDeserializer
    {
        public Currency DeserializeFromStream(FileStream stream)
        {
            var doc = new XmlDocument();
            doc.Load(stream);

            Currency curr = new Currency();
            try
            {
                var root = doc["Currency"];
                curr.Name = root["Code"].InnerText;
                var date = root["Date"].InnerText;
                var rates = root["Rates"];

                curr.BTC = double.Parse(rates["BTC"].InnerText);
                curr.USD = double.Parse(rates["USD"].InnerText);
                curr.EUR = double.Parse(rates["EUR"].InnerText);
                curr.CZK = double.Parse(rates["CZK"].InnerText);
                curr.GBP = double.Parse(rates["GBP"].InnerText);
                curr.CNY = double.Parse(rates["CNY"].InnerText);
                curr.JPY = double.Parse(rates["JPY"].InnerText);

                return curr;

            }

            catch (Exception e)
            {
                throw new InvalidCurrencyXmlException();
            }

        }
    }
}
