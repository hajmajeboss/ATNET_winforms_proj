using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp
{
    public class PluginLoader
    {
        public List<Plugin> GetPlugins()
        {
            List<Plugin> plugins = new List<Plugin>();
            return plugins;
        }

        public CurrencyPlugin LoadPlugin(Plugin plugin)
        {
            throw new InvalidPluginException("Invalid plugin.", plugin);
        }
    }
}
