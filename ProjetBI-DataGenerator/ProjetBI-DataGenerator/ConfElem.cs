using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class ConfElem
    {
        public int Weight { get; set; }
        public string Value { get; set; }

        public ConfElem(int weight, string value)
        {
            Weight = weight;
            Value = value;
        }
    }
}
