using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Packaging : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }
        public int Quantity { get; set; }
        public int Quantity_Box { get; set; }

        public static int count = 0;

        public Packaging(string lib, int quantity, int quantity_Box)
        {
            this.Lib = lib;
            this.Quantity = quantity;
            this.Quantity_Box = quantity_Box;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Packaging[] Import(Dictionary<string, object>[] datas)
        {
            Packaging[] output = new Packaging[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Packaging((string)data["Lib"], (int)(long)data["Quantity"], (int)(long)data["QuantityBox"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO PACKAGING " +
                "(ID_PACKAGING, LIB, QUANTITY, QUANTITY_BOX) VALUES (" +
                this.ID + ", '" +
                this.Lib + "', " +
                this.Quantity + ", " +
                this.Quantity_Box + ");";
        }
        public override string CSVHeader => "ID_PACKAGING;LIB;QUANTITY;QUANTITY_BOX";
        public override string ToCSV()
        {
            return this.ID + ";" +
                this.Lib + ";" +
                this.Quantity + ";" +
                this.Quantity_Box;
        }
    }
}
