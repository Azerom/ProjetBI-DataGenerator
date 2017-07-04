using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Conditioning : Element
    {
        public int ID { get; set; }
        public int Cadence { get; set; }
        public int Delays { get; set; }

        public int ID_Packaging { get; set; }


        public static int count = 0;

        public Conditioning(int cadence, int delays, int id_Packaging)
        {
            this.Cadence = cadence;
            this.Delays = delays;
            this.ID_Packaging = id_Packaging;
            this.ID = count;
            count++;
        }
        
        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Conditioning[] Import(Dictionary<string, object>[] datas)
        {
            Conditioning[] output = new Conditioning[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Conditioning((int)(long)data["Cadence"], (int)(long)data["Delays"],(int)(long)data["ID_Packaging"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO CONDITIONING " +
                "(ID_CONDITIONING, CADENCE, DELAYS, ID_PACKAGING) VALUES (" +
                this.ID + ", " +
                this.Cadence + ", " +
                this.Delays + ", " +
                this.ID_Packaging + ");";
        }
    }
}
