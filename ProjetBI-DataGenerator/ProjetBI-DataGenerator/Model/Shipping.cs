using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Shipping : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }
        public int BoxCapacity { get; set; }
        public int Capacity { get; set; }

        public static int count = 0;

        public Shipping(string lib, int boxCapacity, int capacity)
        {
            this.Lib = lib;
            this.BoxCapacity = boxCapacity;
            this.Capacity = capacity;
            this.ID = count;
            count++;
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Shipping[] Import(Dictionary<string, object>[] datas)
        {
            Shipping[] output = new Shipping[datas.Length];
            int i = 0;
            foreach(Dictionary<string, object> data in datas)
            {
                unchecked
                {
                    output[i] = new Shipping((string)data["Lib"], (int)(long)data["BoxCapacity"], (int)(long)data["Capacity"]);
                }
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO SHIPPING " +
                "(ID_SHIPPING, LIB, BOX_CAPACITY, CAPACITYS) VALUES (" +
                this.ID + ", '" +
                this.Lib + "', " +
                this.BoxCapacity + ", " +
                this.Capacity + ");";
        }
        public override string CSVHeader => "ID_SHIPPING;LIB;BOX_CAPACITY;CAPACITYS";
        public override string ToCSV()
        {

            return this.ID + ";" +
                this.Lib + ";" +
                this.BoxCapacity + ";" +
                this.Capacity;
        }
    }
}
