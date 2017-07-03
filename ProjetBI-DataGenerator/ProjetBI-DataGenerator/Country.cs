using ProjetBI_DataGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class Country : Element
    {
        public int ID { get; set; }
        public string Lib { get; set; }
        public Shipping Ship { get; set; }

        private static int count = 0;

        public Country(string lib, Shipping ship)
        {
            this.ID = count;
            count++;
            this.Lib = lib;
            this.Ship = ship;

        }
        public static new Country[] Import(Dictionary<string, object>[] datas)
        {
            Country[] output = new Country[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Country((string)data["Lib"], (Shipping)data["Shipping"]);
                i++;
            }
            return output;
        }

        public override string ToSQL()
        {
            return this.Ship.ToSQL() + "\n " +
                "INSERT INTO COUNTRY " +
                "(ID, LIB, ID_SHIPPING) VALUES (" +
                this.ID + ", " +
                this.Lib + ", " +
                this.Ship.ID + ");";
        }
    }
}
