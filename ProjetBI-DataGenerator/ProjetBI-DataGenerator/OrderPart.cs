using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class OrderPart
    {
       
        public string ProductType { get; set; }

        public string Color { get; set; }

        public string Variant { get; set; }

        public string Texture { get; set; }

        public string Conditioning { get; set; }

        public int Count { get; set; }

        public string Country { get; set; }

        public OrderPart(RandomPicker config)
        {
            this.ProductType = config.Types;
            this.Color = config.Colors;
            this.Variant = config.Variants;
            this.Texture = config.Textures;
            this.Conditioning = config.Conditionings;
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
