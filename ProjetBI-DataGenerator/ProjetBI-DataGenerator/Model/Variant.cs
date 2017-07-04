using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Variant : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }


        public static int count = 0;

        public Variant(string lib)
        {
            this.Lib = lib;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Variant[] Import(Dictionary<string, object>[] datas)
        {
            Variant[] output = new Variant[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Variant((string)data["Lib"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO VARIANT " +
                "(ID_VARIANT, LIB) VALUES (" +
                this.ID + ", '" +
                this.Lib + "');";
        }

        public override string CSVHeader => "ID_VARIANT;LIB";

        public override string ToCSV()
        {
            return this.ID + ";" +
                this.Lib;
        }
    }
}

