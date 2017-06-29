using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjetBI_DataGenerator.Properties;

namespace ProjetBI_DataGenerator
{
    class Exporter
    {
        public static void toCSV(RandomPicker randPick, bool header)
        {
            //Getting the form
            MainForm form = (MainForm)MainForm.ActiveForm;

            string orderCSVPath = Program.path + Settings.Default.OrderCSVPath;
            string partCSVPath = Program.path + Settings.Default.PartCSVPath;

            File.Delete(orderCSVPath);
            File.Delete(partCSVPath);

            //ID use to display progress
            int lastId = -1000;

            //Opening the CSV
            using (StreamWriter orderFile = new StreamWriter(orderCSVPath, true))
            using (StreamWriter partFile = new StreamWriter(partCSVPath, true))
            {
                //Write a first line as a header
                if (header)
                    partFile.WriteLine("order_ID;type;color;variant;texture;conditioning");

                //Main loop
                for (int i = 0; i < form.GetMaxSize(); i++)
                {
                    Order order = new Order(randPick);

                    //If we have generate 1000 order since last log, make a log
                    if (order.ID >= lastId + 1000)
                    {
                        
                        form.AddLog("Order n° : " + order.ID.ToString() + Environment.NewLine);
                        lastId = order.ID;
                    }

                    //Foreach part in the active order
                    foreach (OrderPart part in order.Parts)
                    {
                        //Prepare the line
                        var newPartLine = string.Format("{0};{1};{2};{3};{4};{5}", order.ID, part.ProductType, part.Color, part.Variant, part.Texture, part.Conditioning);

                        //Write the line
                        partFile.WriteLine(newPartLine);

                    }
                    //Clean buffer memory
                    partFile.Flush();

                    //Prepare and write the line in the order file
                    var newCommandLine = string.Format("{0};{1};{2};{3}", order.ID, order.Country, order.Shipping, order.Date.ToShortDateString());
                    orderFile.WriteLine(newCommandLine);
                    //Clean buffer memory
                    orderFile.Flush();
                }
            }
        }
    }
}
