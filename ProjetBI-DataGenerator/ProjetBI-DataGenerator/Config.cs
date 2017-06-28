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
        private string[,] countries;


        public Config(string[] types, string[] colors, string[] variants, string[] textures, string[] conditionings, string[,] countries)
        {
            this.Types = types;
            this.Colors = colors;
            this.Variants = variants;
            this.Textures = textures;
            this.Conditionings = conditionings;
            this.Countries = countries;
        }

        public static Config LoadConfig(string path)
        {
            string json = System.IO.File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Config>(json);
        }

        public string Tojson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string[] Types { get => types; set => types = value; }
        public string[] Colors { get => colors; set => colors = value; }
        public string[] Variants { get => variants; set => variants = value; }
        public string[] Textures { get => textures; set => textures = value; }
        public string[] Conditionings { get => conditionings; set => conditionings = value; }
        public string[,] Countries { get => countries; set => countries = value; }
    }
}
