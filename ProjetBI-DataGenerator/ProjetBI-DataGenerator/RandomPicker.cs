using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class RandomPicker
    {
        private Random random;
        public Config Conf { get; set; }

        public RandomPicker(Config conf)
        {
            Conf = conf;
            random = new Random();
        }

        private T GetRandFromArray<T>(T[] array)
        {
            return array[random.Next(array.Length)];
        }
        public string Colors
        {
            get
            {
                return GetRandFromArray(Conf.Colors);
            }
        }

        public string Conditionings
        {
            get
            {
                return GetRandFromArray(Conf.Conditionings);
            }
        }

        public string Textures
        {
            get
            {
                return GetRandFromArray(Conf.Textures);
            }
        }

        public string Types
        {
            get
            {
                return GetRandFromArray(Conf.Types);
            }
        }

        public string Variants
        {
            get
            {
                return GetRandFromArray(Conf.Variants);
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
