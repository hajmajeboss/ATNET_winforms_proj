using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            Assembly assembly = Assembly.LoadFrom(Path.Combine(plugin.Address, "CryptoApp." + plugin.Name + ".dll"));
            var type = assembly.GetType("CryptoApp." + plugin.Name + ".CurrencyDataDownloader");

            if (typeof(CurrencyPlugin).IsAssignableFrom(type))
            {
                var ret = (CurrencyPlugin)Activator.CreateInstance(type);
                return ret;
            }
            else
            {
                throw new InvalidPluginException("Invalid plugin.", plugin);
            }

        }
    }
}
