using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class RandomPicker
    {
        private ConfElem[] types, colors, variants, textures, conditionings;

        private Random random;
        public Config Conf { get; set; }

        public RandomPicker(Config conf)
        {
            Conf = conf;
            random = new Random();

            this.types = GenerateWeight(Conf.Types);
            this.colors = GenerateWeight(Conf.Colors);
            this.variants = GenerateWeight(Conf.Variants);
            this.textures = GenerateWeight(Conf.Textures);
            this.conditionings = GenerateWeight(Conf.Conditionings);
        }

        private ConfElem[] GenerateWeight(string[] array)
        {
            ConfElem[] elem = new ConfElem[array.Length];
            int i = 0;
            foreach (string y in array)
            {
                elem[i] = new ConfElem(random.Next(100), y);
                i++;
            }
            return elem;
        }

        private T GetRandFromArray<T>(T[] array)
        {
            return array[random.Next(array.Length)];
        }

        private string GetRandWeight(ConfElem[] array)
        {
            string elem = " ";
            

            while(elem == " ")
            {
                int rand = random.Next(100);
                int index = random.Next(array.Length);

                if (array[index].Weight >= rand)
                    elem = array[index].Value;
            }
            return elem;
        }

        public string Colors
        {
            get
            {
                return GetRandWeight(this.colors);
            }
        }

        public string Conditionings
        {
            get
            {
                return GetRandWeight(this.conditionings);
            }
        }

        public string Textures
        {
            get
            {
                return GetRandWeight(this.textures);
            }
        }

        public string Types
        {
            get
            {
                return GetRandWeight(this.types);
            }
        }

        public string Variants
        {
            get
            {
                return GetRandWeight(this.variants);
            }
        }

        public string[] CountriesAndShipping
        {

            get
            {
                int rand = random.Next(Conf.Countries.GetLength(0));
                string[] values = { Conf.Countries[rand, 0], Conf.Countries[rand, 1] };
                return values;
            }
        }
    }
}
