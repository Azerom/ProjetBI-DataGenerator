using ProjetBI_DataGenerator.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetBI_DataGenerator.Model;

namespace ProjetBI_DataGenerator
{
    class RandomPicker
    {
        private Element[] candyVar;
        
        private Random random;

        public RandomPicker()
        {
            Env env = Program.env;
            this.random = new Random();

            this.candyVar = env.Datas["Candy"];
            
        }


        public Model.Element GetRandWeight(Model.Element[] array)
        {
            Model.Element elem = null;


            while (elem is null)
            {
                int rand = random.Next(100);
                int index = random.Next(array.Length);

                if (array[index].Weight >= rand)
                    elem = array[index];
            }
            return elem;
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
        

        public Candy candy
        {
            get
            {
                return (Candy)GetRandWeight(this.candyVar);
            }
        }
        
    }
}
