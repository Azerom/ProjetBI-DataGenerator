using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Component : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }
        public int Conditioning { get; set; }
        public int Palette { get; set; }

        public static int count = 0;

        public Component(string lib, int conditioning, int palette)
        {
            this.Lib = lib;
            this.Conditioning = conditioning;
            this.Palette = palette;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Component[] Import(Dictionary<string, object>[] datas)
        {
            Component[] output = new Component[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Component((string)data["Lib"], (int)(long)data["Conditioning"], (int)(long)data["Palette"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO COMPONENTS " +
                "(ID_COMPONENT, LIB, CONDITIONING, PALETTE) VALUES (" +
                this.ID + ", '" +
                this.Lib + "', " +
                this.Conditioning + ", " +
                this.Palette + ");";
        }
    }
}
