using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetBI_DataGenerator.Model;

namespace ProjetBI_DataGenerator
{
    class Order
    {
        private static int count = 0;

        public Guid ID { get; set; }

        private OrderPart[] parts;

        public int Country { get; set; }

        public DateTime Date { get; set; }

        private static Random rand = new Random();

        public Order(OrderPart[] parts, int country)
        {
            Parts = parts;
            Country = country;
        }

        public Order(RandomPicker conf)
        {
            
            int size = rand.Next(1, Settings.Default.MaxOrderParts + 1 );

            parts = new OrderPart[size];
            this.ID = Guid.NewGuid();
            for (int i = 0; i < size; i++)
            {
                parts[i] = new OrderPart(conf, this.ID);
            }

            Country country = (Country)conf.GetRandWeight(Program.env.Datas["Country"]);

            Country = country.ID;

            Date = conf.RandomDay();

            
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
            string str = "Order to " + Country + " :" + Environment.NewLine;

            foreach(OrderPart part in parts)
            {
                str += part.toString() + Environment.NewLine;
            }
          

            return str;
        }

        public string ToSQL()
        {
            return "INSERT INTO ORDERS (ID_ORDER, DATE_ORDER, ID_COUNTRY) VALUES ('" +
                this.ID.ToString() + "', '" +
                this.Date.ToShortDateString() + "', " +
                this.Country + ");";
        }
    }
}


