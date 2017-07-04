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

        private void m_sql_Click(object sender, EventArgs e)
        {
            RandomPicker randPick = new RandomPicker();
            if(Exporter.toSQL(randPick, m_datasCheck.Checked))
                MessageBox.Show("Finish");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
