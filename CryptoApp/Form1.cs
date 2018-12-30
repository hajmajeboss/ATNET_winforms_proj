using CryptoApp.ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CryptoApp
{
    public partial class Form1 : Form
    {
        Currency curr;

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
            saveFileDialog1.Title = "Save to XML File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                var serializer = new CurrencyToXmlSerializer();
                if (curr != null)
                {
                    serializer.SerializeToStream(curr, fs);
                }
                fs.Close();
                if (curr != null)
                {
                    MessageBox.Show("Successfully saved.", "Save to XML file");
                }
                else
                {
                    MessageBox.Show("An error occured while saving.", "Save to XML file");
                }
            }
        }

        private void LoadFromXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.Title = "Select a XML File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = (FileStream)openFileDialog1.OpenFile();
                var deserializer = new XmlToCurrencyDeserializer();
                curr = deserializer.DeserializeFromStream(fs);
                CurrencyRateGrid.DataSource = GenerateCurrencyRatesList();
                CodeLabel.Text = "Code: " + curr.Name;

                PluginComboBox.Text = "from XML";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            Plugin selected = (Plugin)combo.SelectedItem;

            try
            {
                PluginLoader loader = new PluginLoader();
                curr = loader.LoadPlugin(selected).GetCurrencyData();           
                CurrencyRateGrid.DataSource = GenerateCurrencyRatesList();
                CodeLabel.Text = "Code: " + curr.Name;
            }
            catch (InvalidPluginException ipe)
            {
                Trace.WriteLine(ipe.Message + " " + ipe.plugin);
                Debug.WriteLine(ipe.Message + " " + ipe.plugin);
                MessageBox.Show(ipe.plugin + " is not a valid CryptoApp plugin.", "Error");
            }
        }


        public List<CurrencyNameRate> GenerateCurrencyRatesList()
        {
            List<CurrencyNameRate> list = new List<CurrencyNameRate>();
            list.Add(new CurrencyNameRate { Code = "BTC", Rate = curr.BTC });
            list.Add(new CurrencyNameRate { Code = "EUR", Rate = curr.EUR });
            list.Add(new CurrencyNameRate { Code = "USD", Rate = curr.USD });
            list.Add(new CurrencyNameRate { Code = "CNY", Rate = curr.CNY });
            list.Add(new CurrencyNameRate { Code = "JPY", Rate = curr.JPY });
            list.Add(new CurrencyNameRate { Code = "CZK", Rate = curr.CZK });
            list.Add(new CurrencyNameRate { Code = "GBP", Rate = curr.GBP });
            return list;
        }
    }
}
