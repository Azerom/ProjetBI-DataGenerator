using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjetBI_DataGenerator
{
    class Config
    {
        [JsonProperty]
        private Dictionary<string, object>[] shipping, country, packaging, componentGramme, type, price;
        
        [JsonProperty]
        private Dictionary<string, object>[] fabrication, conditioning, variant, color, texture, component;

        public Dictionary<string, object>[] Shipping { get => shipping; set => shipping = value; }
        public Dictionary<string, object>[] Country { get => country; set => country = value; }
        public Dictionary<string, object>[] Packaging { get => packaging; set => packaging = value; }
        public Dictionary<string, object>[] ComponentGramme { get => componentGramme; set => componentGramme = value; }
        public Dictionary<string, object>[] Type { get => type; set => type = value; }
        public Dictionary<string, object>[] Price { get => price; set => price = value; }
        public Dictionary<string, object>[] Fabrication { get => fabrication; set => fabrication = value; }
        public Dictionary<string, object>[] Conditioning { get => conditioning; set => conditioning = value; }
        public Dictionary<string, object>[] Variant { get => variant; set => variant = value; }
        public Dictionary<string, object>[] Color { get => color; set => color = value; }
        public Dictionary<string, object>[] Texture { get => texture; set => texture = value; }
        public Dictionary<string, object>[] Component { get => component; set => component = value; }

        public static Config Load(string path)
        {
            return JsonConvert.DeserializeObject<Config>(System.IO.File.ReadAllText(path));
        }

    }
}
