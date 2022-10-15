using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Interface
{
    public interface IMap<TKey, TValue>
    {
        /// <summary>
        /// Put a key value into the map, override pre-existing value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Put(TKey key, TValue value);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns>True if object added, false if not</returns>
        public bool PutIfAbstract(TKey key, TValue value);
        public TValue GetValue(TKey key);
        public IEnumerable<TKey> GetKeys();
    }
}
