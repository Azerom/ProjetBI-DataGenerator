using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class Order
    {
        private OrderPart[] parts;

        public Order(OrderPart[] parts)
        {
            this.parts = parts;
        }

        public Order(Config conf)
        {
            Random rand = new Random();
            int size = rand.Next(1, 16);

            parts = new OrderPart[size];

            for (int i = 0; i < size; i++)
            {
                parts[i] = new OrderPart(conf);
            }
        }

        public OrderPart[] Parts
        {
            get
            {
                return parts;
            }

            set
            {
                parts = value;
            }
        }

        public override string ToString()
        {
            string str = "Order :" + Environment.NewLine;

            foreach(OrderPart part in parts)
            {
                str += part.toString() + Environment.NewLine;
            }

            return str;
        }
    }
}
