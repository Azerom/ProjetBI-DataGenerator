using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class OrderPart
    {
        private static Random rand = new Random();
        public string ProductType { get; set; }

        public string Color { get; set; }

        public string Variant { get; set; }

        public string Texture { get; set; }

        public string Conditioning { get; set; }

        public int Count { get; set; }

        public string Country { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public OrderPart(RandomPicker picker)
        {
            this.ProductType = picker.Types;
            this.Color = picker.Colors;
            this.Variant = picker.Variants;
            this.Texture = picker.Textures;
            this.Conditioning = picker.Conditionings;
            this.Quantity = rand.Next(1 ,Settings.Default.MawQuantityPerPart + 1);
            this.Price = picker.GetPrice(this.ProductType, this.Conditioning);
        }

        public string toString()
        {
            return ProductType + " " +
                Color + " " +
                Variant + " " +
                Texture + " " +
                Conditioning;
        }

    }
}
