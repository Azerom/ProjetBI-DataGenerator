using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    class Component_Gramme : Element
    {
        public int Valeur { get; set; }
        public int ID_Type { get; set; }
        public int ID_Component { get; set; }
        

        public static int count = 0;

        public Component_Gramme(int valeur, int id_Type, int id_Component)
        {
            this.Valeur = valeur;
            this.ID_Type = id_Type;
            this.ID_Component = id_Component;
           
        }

        //Generate an array of Shipping base on an array of dictionary (each disctionary has the proprities of a Shipping)
        public static new Component_Gramme[] Import(Dictionary<string, object>[] datas)
        {
            Component_Gramme[] output = new Component_Gramme[datas.Length];
            int i = 0;
            foreach (Dictionary<string, object> data in datas)
            {
                output[i] = new Component_Gramme((int)(long)data["Valeur"], (int)(long)data["ID_Type"], (int)(long)data["ID_Component"]);
                i++;
            }
            return output;
        }
        public override string ToSQL()
        {

            return "INSERT INTO COMPONENT_GRAMME " +
                "(VALEUR, ID_TYPE, ID_COMPONENT) VALUES (" +
                this.Valeur + ", " +
                this.ID_Type + ", " +
                this.ID_Component + ");";
        }
    }
}
