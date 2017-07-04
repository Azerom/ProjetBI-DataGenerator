using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Texture : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }
      

        public static int count = 0;

        public Texture(string lib)
        {
            this.Lib = lib;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Texture[] Import(Dictionary<string, object>[] datas)
        {
            Texture[] output = new Texture[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Texture((string)data["Lib"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO TEXTURE " +
                "(ID_TEXTURE, LIB) VALUES (" +
                this.ID + ", '" +
                this.Lib + "');";
        }
        public override string CSVHeader => "ID_TEXTURE;LIB";
        public override string ToCSV()
        {
            return this.ID + ";" +
                this.Lib;
        }
    }
}
