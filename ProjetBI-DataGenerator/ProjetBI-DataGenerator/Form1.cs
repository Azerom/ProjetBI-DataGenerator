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

            RandomPicker randPick = new RandomPicker(Program.config);
            
            Order order = new Order(randPick);

            m_log.Text = order.ToString();

            m_export.Enabled = true;
            
        }

        private void exportClick(object sender, EventArgs e)
        {

        }
    }
}
