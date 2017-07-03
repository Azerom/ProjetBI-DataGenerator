using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBI_DataGenerator.Model
{
    public class GenericDictionary
    {
        private Dictionary<string, object> _dict = new Dictionary<string, object>();

        public void Add<T>(string key, T value) where T : class
        {
            _dict.Add(key, value);
        }

        public T Get<T>(string key) where T : class
        {
            return _dict[key] as T;
        }
    }
}
