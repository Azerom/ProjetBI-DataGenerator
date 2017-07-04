using Newtonsoft.Json;
using ProjetBI_DataGenerator.Model;
using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBI_DataGenerator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        private void exportClick(object sender, EventArgs e)
        {
            Config config = Config.Load(@"C:\Users\Azerom\Source\Repos\ProjetBI-DataGenerator\ProjetBI-DataGenerator\ProjetBI-DataGenerator\bin\Debug\config.json");

            MessageBox.Show(JsonConvert.SerializeObject(config));

            Dictionary<string, object>[] ShiptestData = new Dictionary<string, object>[1];
            ShiptestData[0] = new Dictionary<string, object>();
            ShiptestData[0].Add("Lib", "TestLib");
            ShiptestData[0].Add("BoxCapacity", 42);
            ShiptestData[0].Add("Capacity", 43);

            Shipping[] ships = Shipping.Import(config.Shipping);

            Dictionary<string, object>[] CountrytestData = new Dictionary<string, object>[1];
            CountrytestData[0] = new Dictionary<string, object>();
            CountrytestData[0].Add("Lib", "TestLib");
            CountrytestData[0].Add("Shipping", 0);

            Country[] country = Country.Import(config.Country);

            MessageBox.Show(country[0].ToSQL());

            RandomPicker randPick = new RandomPicker();

            if(Exporter.toCSV(randPick, m_checkHeader.Checked))
                MessageBox.Show("Finish");
        }

        private void m_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddLog(string txt)
        {
            m_log.AppendText(txt);
        }

        public long GetMaxSize()
        {
            return Convert.ToInt64(m_sizeController.Text);
        }
    }
}
