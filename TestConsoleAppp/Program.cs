using CryptoApp.Litecoin;
using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleAppp
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyDataDownloader dl = new CurrencyDataDownloader();
            Currency curr = dl.GetCurrencyData();

            Console.WriteLine("Name: {0}, BTC: {1}, EUR: {2}, CZK {3}", curr.Name, curr.BTC, curr.EUR, curr.CZK);

            Console.ReadKey();
        }

    }
}
