using Map.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Impl
{
    public class MapImpl<T, V> : IMap<T, V>
    {
        private readonly Dictionary<T, V> _dict = new Dictionary<T, V>();
        public V Get(T key)
        {
            if (_dict.ContainsKey(key))
            {
                return _dict[key];
            }
            return default(V);
        }

        public IEnumerable<T> GetKeys()
        {
            throw new NotImplementedException();
        }

        public void Put(T key, V value)
        {
            _dict.Add(key, value);
        }

        public bool PutIfAbstract(T key, V value)
        {
            throw new NotImplementedException();
        }
    }
}
