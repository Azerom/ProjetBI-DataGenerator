using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Type : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }
        public int Fabrication { get; set; }
        public int Conditioning { get; set; }

        public int Shipping { get; set; }

        public int Generale { get; set; }

        public static int count = 0;

        public Type(string lib, int fabrication, int conditioning, int shipping, int generale)
        {
            this.Lib = lib;
            this.Fabrication = fabrication;
            this.Conditioning = conditioning;
            this.Shipping = shipping;
            this.Generale = generale;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Type[] Import(Dictionary<string, object>[] datas)
        {
            Type[] output = new Type[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Type((string)data["Lib"], (int)(long)data["Fabrication"], (int)(long)data["Conditioning"], (int)(long)data["Shipping"], (int)(long)data["General"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO TYPECANDY " +
                "(ID_TYPE, LIB, FABRICATION, CONDITIONING, SHIPPING, GENERALE) VALUES (" +
                this.ID + ", '" +
                this.Lib + "', " +
                this.Fabrication + ", " +
                this.Conditioning + ", "+
                this.Shipping + ", "+
                this.Generale + ");";
        }
    }
}
