using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Fabrication : Element
    {
        public int ID { get; set; }
        public int Cadence { get; set; }
        public int IDMachine { get; set; }
        public int Delay { get; set; }

        public int IDVariante { get; set; }

        public static int count = 0;

        public Fabrication(int cadence, int idmachine, int delay, int variante)
        {
            this.Cadence = cadence;
            this.IDMachine = idmachine;
            this.Delay = delay;
            this.ID = count;
            this.IDVariante = variante;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Fabrication[] Import(Dictionary<string, object>[] datas)
        {
            Fabrication[] output = new Fabrication[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Fabrication((int)(long)data["Cadence"], (int)(long)data["IdMachine"], (int)(long)data["Delays"], (int)(long)data["IdVariant"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO FABRICATION " +
                "(ID_FABRICATION, CADENCE, ID_MACHINE, DELAYS, ID_VARIANT) VALUES (" +
                this.ID + ", " +
                this.Cadence + ", " +
                this.IDMachine + ", " +
                this.Delay + ", " +
                this.IDVariante + ");";
        }
        public override string CSVHeader => "ID_FABRICATION;CADENCE;ID_MACHINE;DELAYS;ID_VARIANT";
        public override string ToCSV()
        {
            return this.ID + ";" +
                this.Cadence + ";" +
                this.IDMachine + ";" +
                this.Delay + ";" +
                this.IDVariante;
        }
    }
}
