using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Color : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }


        public static int count = 0;

        public Color(string lib)
        {
            this.Lib = lib;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Color[] Import(Dictionary<string, object>[] datas)
        {
            Color[] output = new Color[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Color((string)data["Lib"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO COLOR " +
                "(ID_COLOR, LIB) VALUES (" +
                this.ID + ", " +
                this.Lib + ");";
        }
    }
}
