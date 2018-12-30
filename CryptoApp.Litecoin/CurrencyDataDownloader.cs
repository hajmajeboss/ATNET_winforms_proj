using CryptoApp.ClassLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CryptoApp.Litecoin
{
    public class CurrencyDataDownloader : CurrencyPlugin
    {
        public Currency GetCurrencyData()
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData("https://min-api.cryptocompare.com/data/pricemulti?fsyms=LTC&tsyms=BTC,USD,EUR,GBP,CNY,JPY,CZK&api_key=02c104ca42549c53eb8ec9d752626997e5f287a162ae86f30e33b1f5c3bd637a");
            string dataJson = System.Text.Encoding.UTF8.GetString(data);

            dynamic dataParsed = JsonConvert.DeserializeObject(dataJson);

            Currency curr = new Currency
            {
                Name = "LTC",
                BTC = dataParsed.LTC.BTC,
                CNY = dataParsed.LTC.CNY,
                EUR = dataParsed.LTC.EUR,
                USD = dataParsed.LTC.USD,
                GBP = dataParsed.LTC.GBP,
                CZK = dataParsed.LTC.CZK,
                JPY = dataParsed.LTC.JPY
            };

            return curr;
        }
    }
}
