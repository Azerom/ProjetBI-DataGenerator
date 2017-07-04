﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjetBI_DataGenerator.Properties;
using System.Windows.Forms;
using ProjetBI_DataGenerator.Model;

namespace ProjetBI_DataGenerator
{
    class Exporter
    {
        private Model.Element SelectRand(Model.Element[] array)
        {
            Random random = new Random();
            Model.Element elem = null;


            while (elem is null)
            {
                int rand = random.Next(100);
                int index = random.Next(array.Length);

                if (array[index].Weight >= rand)
                    elem = array[index];
            }
            return elem;
        }
        
        public static bool toSQL(RandomPicker rand, bool withDatas)
        {
            //Getting the form
            MainForm form = (MainForm)MainForm.ActiveForm;
            string SQLPath = Program.path + @"\SQL.sql";

            try
            {
                File.Delete(SQLPath);
                using (StreamWriter file = new StreamWriter(File.Open(SQLPath, FileMode.OpenOrCreate), Encoding.UTF8))
                {

                    if (withDatas)
                    {
                        foreach (KeyValuePair<string, Element[]> entry in Program.env.Datas)
                        {
                            foreach (Element elem in entry.Value)
                            {
                                file.WriteLine(elem.ToSQL());
                            }
                        }
                    }


                    for (int i = 0; i < form.GetMaxSize(); i++)
                    {
                        Order order = new Order(rand);

                        //Foreach part in the active order
                        foreach (OrderPart part in order.Parts)
                        {
                            
                            //Write the line
                            file.WriteLine(part.ToSQL());

                        }
                        //Clean buffer memory
                        file.Flush();

                        file.WriteLine(order.ToSQL());
                    }

                };
                return true;
            }
            catch (System.IO.IOException)
            {

                MessageBox.Show("Files already in use by another app");
                return false;
            }

        }
        public static bool toCSV(RandomPicker randPick, bool header)
        {
            //Getting the form
            MainForm form = (MainForm)MainForm.ActiveForm;
            DateTime date = DateTime.Now;

            string dateString = date.ToShortDateString().Replace('/', '-') + "_" + date.ToShortTimeString().Replace(':', '-');

            try
            {
                string subpath = Program.path + @"\output\" + dateString;
                System.IO.Directory.CreateDirectory(subpath);
                foreach (KeyValuePair<string, Element[]> entry in Program.env.Datas)
                {
                    
                    string path =  subpath + @"\" + dateString + entry.Key + ".csv";
                    File.Delete(path);
                    using (StreamWriter file = new StreamWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
                    {
                        if (header)
                        {
                            file.WriteLine(entry.Value[0].CSVHeader);
                        }
                        
                        foreach (Element elem in entry.Value)
                        {
                            file.WriteLine(elem.ToCSV());
                        }
                        
                    }

                }

                string orderPath = subpath + @"\" + dateString + "Order" + ".csv";
                string orderPartPath = subpath + @"\" + dateString + "OrderPart" + ".csv";
                File.Delete(orderPath);
                File.Delete(orderPartPath);



                using (StreamWriter orderFile = new StreamWriter(File.Open(orderPath, FileMode.OpenOrCreate), Encoding.UTF8)) 
                using (StreamWriter orderPartFile = new StreamWriter(File.Open(orderPartPath, FileMode.OpenOrCreate), Encoding.UTF8))
                {
                    if (header)
                    {
                        orderFile.WriteLine(Order.CSVHeader);
                        orderPartFile.WriteLine(OrderPart.CSVHeader);
                    }
                    for (int i = 0; i < form.GetMaxSize(); i++)
                    {
                        Order order = new Order(randPick);

                        //Foreach part in the active order
                        foreach (OrderPart part in order.Parts)
                        {

                            //Write the line
                            orderPartFile.WriteLine(part.ToCSV());

                        }
                        //Clean buffer memory
                        
                        orderFile.WriteLine(order.ToCSV());
                     
                    }
                }


                //    File.Delete(orderCSVPath);
                //File.Delete(partCSVPath);


                ////Opening the CSV
                //using (StreamWriter orderFile = new StreamWriter(File.Open(orderCSVPath, FileMode.OpenOrCreate), Encoding.UTF8))
                //using (StreamWriter partFile = new StreamWriter(File.Open(partCSVPath, FileMode.OpenOrCreate), Encoding.UTF8))
                //{
                //    //Write a first line as a header
                //    if (header)
                //    {
                //        partFile.WriteLine("id;order_ID;type;color;variant;texture;conditioning;price;quantity");
                //        orderFile.WriteLine("id;country;shipping;date");
                //    }

                //    //Main loop
                //    for (int i = 0; i < form.GetMaxSize(); i++)
                //    {
                //        Order order = new Order(randPick);





                //        //Foreach part in the active order
                //        foreach (OrderPart part in order.Parts)
                //        {
                //            //Prepare the line
                //            var newPartLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7}", 
                //                part.ID.ToString("N"),
                //                order.ID.ToString("N"), 
                //                part.Quantity);

                //            //Write the line
                //            partFile.WriteLine(newPartLine);

                //        }
                //        //Clean buffer memory
                //        partFile.Flush();

                //        //Prepare and write the line in the order file
                //        var newCommandLine = string.Format("{0};{1};{2};{3}", 
                //            order.ID.ToString("N"), 
                //            order.Country, 
                //            order.Date.ToShortDateString());
                //        orderFile.WriteLine(newCommandLine);
                //        //Clean buffer memory
                //        orderFile.Flush();
                //    }
                //}

                return true;
            }
            catch (System.IO.IOException)
            {

                MessageBox.Show("Files already in use by another app");
                return false;
            }




        }
    }
}
