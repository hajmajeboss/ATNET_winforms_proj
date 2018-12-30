using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoApp.ClassLib
{
    public interface CurrencyPlugin
    {
        Currency GetCurrencyData();
    }
}
