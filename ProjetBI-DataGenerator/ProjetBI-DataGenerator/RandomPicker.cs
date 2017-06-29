using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator
{
    class RandomPicker
    {
        private ConfElem[] types, colors, variants, textures, conditionings, countries;

        Dictionary<string, float[]> prices;

        private Random random;

        public RandomPicker()
        {
            this.random = new Random();

            this.types = GenerateWeight(Settings.Default.Types.Split(','));
            this.colors = GenerateWeight(Settings.Default.Colors.Split(','));
            this.variants = GenerateWeight(Settings.Default.Variants.Split(','));
            this.textures = GenerateWeight(Settings.Default.Textures.Split(','));
            this.conditionings = GenerateWeight(Settings.Default.Conditioning.Split(','));
            this.countries = GenerateWeight(Settings.Default.Countries.Split(';'));

            //-----PRICE----

            string[] pricesList = Settings.Default.Types.Split(',');

            this.prices = new Dictionary<string, float[]>();
            
            foreach (string prices in pricesList)
            {
                string[] temp = prices.Split(';');

                float[] tempArray = {
                    float.Parse(temp[1], CultureInfo.InvariantCulture.NumberFormat),
                    float.Parse(temp[2], CultureInfo.InvariantCulture.NumberFormat),
                    float.Parse(temp[3], CultureInfo.InvariantCulture.NumberFormat) };
                this.prices[temp[0]] = tempArray;
                
            }



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

        public DateTime RandomDay()
        {
            DateTime start = Settings.Default.StartDate;
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        private T GetRandFromArray<T>(T[] array)
        {
            return array[random.Next(array.Length)];
        }

        public float GetPrice(string index, string cond)
        {
            int condIndex = Array.IndexOf(Settings.Default.Conditioning.Split(','), cond);
            return this.prices[index][condIndex];
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
                return GetRandWeight(this.types).Split(';')[0];
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
                return GetRandWeight(this.countries).Split(',');
            }
        }
    }
}
