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
            MainForm form = (MainForm)MainForm.ActiveForm;

            string orderCSVPath = Program.path + Settings.Default.OrderCSVPath;
            string partCSVPath = Program.path + Settings.Default.PartCSVPath;

            File.Delete(orderCSVPath);
            File.Delete(partCSVPath);

            //before your loop
            var partCsv = new StringBuilder();
            var commandCsv = new StringBuilder();

            int lastId = -1000;

            using (StreamWriter orderFile = new StreamWriter(orderCSVPath, true))
            using (StreamWriter partFile = new StreamWriter(partCSVPath, true))
            {

                if (header)
                    orderFile.WriteLine("order_ID;type;color;variant;texture;conditioning");

                for (int i = 0; i < form.GetMaxSize(); i++)
                {
                    Order order = new Order(randPick);

                    if (order.ID >= lastId + 1000)
                    {
                        
                        form.AddLog("Order n° : " + order.ID.ToString() + Environment.NewLine);
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
        }
    }
}
