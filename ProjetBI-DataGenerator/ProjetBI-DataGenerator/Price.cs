using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Price : Element
    {
        public float Valeur { get; set; }
        public int ID_Packaging { get; set; }
        public int ID_Type { get; set; }
        

        public static int count = 0;

        public Price(float valeur, int id_Packaging, int id_Type)
        {
            this.Valeur = valeur;
            this.ID_Packaging = id_Packaging;
            this.ID_Type = id_Type;
            
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Price[] Import(Dictionary<string, object>[] datas)
        {
            Price[] output = new Price[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Price((float)data["Valeur"], (int)(long)data["ID_Packaging"], (int)(long)data["ID_Type"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO PRICE " +
                "(VALEUR, ID_PACKAGING, ID_TYPE) VALUES (" +
                this.Valeur + ", " +
                this.ID_Packaging + ", " +
                this.ID_Type + ");";
        }
    }
}
