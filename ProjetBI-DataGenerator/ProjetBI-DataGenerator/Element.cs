using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    abstract class Element
    {
        public static Element[] Import(Dictionary<string, object>[] datas)
        {
            return null;
        }

        public abstract string ToSQL();
    }
}
