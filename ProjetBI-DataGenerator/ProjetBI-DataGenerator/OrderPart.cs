using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetBI_DataGenerator.Model;

namespace ProjetBI_DataGenerator
{
    class OrderPart
    {
        private static Random rand = new Random();
        public Candy candy { get; set; }
        
       
        public int Quantity { get; set; }

        public Guid ID { get; set; }

        public Guid OrderID { get; set; }

        public OrderPart(RandomPicker picker, Guid orderID)
        {
            this.candy = picker.candy;
            this.Quantity = rand.Next(1 ,Settings.Default.MawQuantityPerPart + 1);
            this.ID = Guid.NewGuid();
            this.OrderID = orderID;
        }

        public string toString()
        {
            return "";
        }

        public string toSQL()
        {
            return "INSERT INTO ORDERPART (ID_ORDERPART, QUANTITY, ID_ORDER, ID_CANDY) VALUES ('" +
                this.ID.ToString() + "', " +
                this.Quantity + ", '" +
                this.OrderID.ToString() + "', " +
                this.candy.ID + ");";
        }

    }
}
