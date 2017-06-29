using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class Order
    {
        private static int count = 0;

        public int ID { get; set; }

        private OrderPart[] parts;

        public string Country { get; set; }

        public string Shipping { get; set; }

        public DateTime Date { get; set; }


        public Order(OrderPart[] parts, string country, string shipping)
        {
            Parts = parts;
            Country = country;
            Shipping = shipping;
        }

        public Order(RandomPicker conf)
        {
            Random rand = new Random();
            int size = rand.Next(1, Settings.Default.MaxOrderParts + 1 );

            parts = new OrderPart[size];

            for (int i = 0; i < size; i++)
            {
                parts[i] = new OrderPart(conf);
            }

            string[] countryAndShipping = conf.CountriesAndShipping;

            Country = countryAndShipping[0];
            Shipping = countryAndShipping[1];

            Date = conf.RandomDay();

            this.ID = Order.Count;
            Order.Count++;
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

        public static int Count { get => count; set => count = value; }

        public override string ToString()
        {
            string str = "Order to " + Country + " by " + Shipping + " :" + Environment.NewLine;

            foreach(OrderPart part in parts)
            {
                str += part.toString() + Environment.NewLine;
            }
          

            return str;
        }
    }
}


