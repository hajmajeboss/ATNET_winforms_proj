using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApp
{
    public class InvalidPluginException : Exception
    {
        public Plugin plugin { get; set; }
       
        public InvalidPluginException(string msg, Plugin plugin) : base(msg)
        {
            this.plugin = plugin;
        }
    }
}
