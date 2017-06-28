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

namespace ProjetBI_DataGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void generateClick(object sender, EventArgs e)
        {

            string configPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\config.json";

            Config config = Config.LoadConfig(configPath);

            RandomPicker randPick = new RandomPicker(config);

            
            Order order = new Order(randPick);

            textBox1.Text = order.ToString();
            
        }
    }
}
