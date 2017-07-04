using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    abstract class Element
    {
        private static Random rand = new Random();
        private int weight = rand.Next(100);
        private Dictionary<string, object> data = new Dictionary<string, object>();

        public int Weight { get => weight; set => weight = value; }

        public static Element[] Import(Dictionary<string, object>[] datas)
        {
            return null;
        }

        public abstract string ToCSV();

        public abstract string ToSQL();

        public abstract string CSVHeader { get;}
    }
}
