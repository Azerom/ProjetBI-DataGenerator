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
        private string[,] countries;


        public Config(string[] types, string[] colors, string[] variants, string[] textures, string[] conditionings, string[,] countries)
        {
            this.types = types;
            this.colors = colors;
            this.variants = variants;
            this.textures = textures;
            this.conditionings = conditionings;
            this.countries = countries;
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

        public string[] CountriesAndShipping
        {
            
            get
            {
                int rand = random.Next(countries.GetLength(0));
                string[] values = { countries[rand, 0], countries[rand, 1] };
                return values;
            }
        }
    }
}
