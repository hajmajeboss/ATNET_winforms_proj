using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CryptoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PluginComboBox.DataSource = new PluginLoader().GetPlugins();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveToXmlButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML File|*.xml";
            saveFileDialog1.Title = "Save an XML File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                fs.Close();
            }
        }

        private void LoadFromXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select a XML File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            Plugin selected = (Plugin)combo.SelectedItem;

            try
            {
                PluginLoader loader = new PluginLoader();
                Currency curr = loader.LoadPlugin(selected).GetCurrencyData();
                List<CurrencyNameRate> list = new List<CurrencyNameRate>();
                list.Add(new CurrencyNameRate { Code = "EUR", Rate = curr.EUR });
                list.Add(new CurrencyNameRate { Code = "BTC", Rate = curr.BTC });
                list.Add(new CurrencyNameRate { Code = "USD", Rate = curr.USD });
                list.Add(new CurrencyNameRate { Code = "CNY", Rate = curr.CNY });
                list.Add(new CurrencyNameRate { Code = "JPY", Rate = curr.JPY });
                list.Add(new CurrencyNameRate { Code = "CZK", Rate = curr.CZK });
                list.Add(new CurrencyNameRate { Code = "GBP", Rate = curr.GBP });
                CurrencyRateGrid.DataSource = list;
            }
            catch (InvalidPluginException ipe)
            {
                Trace.WriteLine(ipe.Message + " " + ipe.plugin);
                Debug.WriteLine(ipe.Message + " " + ipe.plugin);
                MessageBox.Show(ipe.plugin + " is not a valid CryptoApp plugin.", "Error");
            }
        }

    }
}
