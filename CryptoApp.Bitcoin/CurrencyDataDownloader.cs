using CryptoApp.ClassLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CryptoApp.Bitcoin
{
    public class CurrencyDataDownloader : CurrencyPlugin
    {
        public Currency GetCurrencyData()
        {
            WebClient wc = new WebClient();
            byte[] data = wc.DownloadData("https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC&tsyms=BTC,USD,EUR,GBP,CNY,JPY,CZK&api_key=02c104ca42549c53eb8ec9d752626997e5f287a162ae86f30e33b1f5c3bd637a");
            string dataJson = System.Text.Encoding.UTF8.GetString(data);

            dynamic dataParsed = JsonConvert.DeserializeObject(dataJson);

            Currency curr = new Currency
            {
                Name = "BTC",
                BTC = dataParsed.BTC.BTC,
                CNY = dataParsed.BTC.CNY,
                EUR = dataParsed.BTC.EUR,
                USD = dataParsed.BTC.USD,
                GBP = dataParsed.BTC.GBP,
                CZK = dataParsed.BTC.CZK,
                JPY = dataParsed.BTC.JPY
            };

            return curr;
        }
    }
}
