using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class Config
    {
        private string[] types, colors, variants, textures, conditionings;
        private Random random = new Random();


        public Config(string[] types, string[] colors, string[] variants, string[] textures, string[] conditionings)
        {
            this.types = types;
            this.colors = colors;
            this.variants = variants;
            this.textures = textures;
            this.conditionings = conditionings;
        }

        public string Colors
        {
            get
            {
                return colors[random.Next(colors.Length)];
            }
        }

        public string Conditionings
        {
            get
            {
                return conditionings[random.Next(conditionings.Length)];
            }
        }

        public string Textures
        {
            get
            {
                return textures[random.Next(textures.Length)];
            }
        }

        public string Types
        {
            get
            {
                return types[random.Next(types.Length)];
            }
        }

        public string Variants
        {
            get
            {
                return variants[random.Next(variants.Length)];
            }
        }
    }
}
