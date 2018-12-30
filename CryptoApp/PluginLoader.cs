using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
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
            DirectoryInfo nfo = new DirectoryInfo("Plugins");
            foreach (var dir in nfo.GetDirectories())
            {
                Plugin plug = new Plugin
                {
                    Name = dir.Name,
                    Address = dir.FullName
                };

                plugins.Add(plug);
            }
            return plugins;
        }

        public CurrencyPlugin LoadPlugin(Plugin plugin)
        {
            throw new InvalidPluginException("Invalid plugin.", plugin);
        }
    }
}
