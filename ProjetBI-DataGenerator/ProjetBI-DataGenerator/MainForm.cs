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
    public partial class MainForm : Form
    {
        private Order[] orders;


        public MainForm()
        {
            InitializeComponent();


        }

        private void exportClick(object sender, EventArgs e)
        {
            RandomPicker randPick = new RandomPicker(Program.config);

            File.Delete(Program.path + @"\command.csv");
            File.Delete(Program.path + @"\part.csv");
            
            //before your loop
            var partCsv = new StringBuilder();
            var commandCsv = new StringBuilder();

            int lastId = -1000;

            using (System.IO.StreamWriter orderFile = new System.IO.StreamWriter(Program.path + @"\command.csv", true))
            using (System.IO.StreamWriter partFile = new System.IO.StreamWriter(Program.path + @"\part.csv", true))
            {

                if(m_checkHeader.Checked)
                orderFile.WriteLine("order_ID;type;color;variant;texture;conditioning");

                for (int i = 0; i < Convert.ToInt64(m_sizeController.Text); i++)
                {
                    Order order = new Order(randPick);

                    if(order.ID >= lastId + 1000)
                    {
                        m_log.AppendText("Order n° : " + order.ID.ToString() + Environment.NewLine);
                        lastId = order.ID;
                    }
                    

                    foreach (OrderPart part in order.Parts)
                    {
                        var newPartLine = string.Format("{0};{1};{2};{3};{4};{5}", order.ID, part.ProductType, part.Color, part.Variant, part.Texture, part.Conditioning);
                        
                            partFile.WriteLine(newPartLine);
                        
                    }
                        partFile.Flush();

                        var newCommandLine = string.Format("{0};{1};{2}", order.ID, order.Country, order.Shipping);
                    orderFile.WriteLine(newCommandLine);
                    orderFile.Flush();
                }
            }


            //after your loop

            MessageBox.Show("Finish");
        }

        private void m_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
