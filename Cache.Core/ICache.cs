using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core
{
    public interface ICache<TKey, TValue> : IDisposable
    {
        bool Add(TKey key, TValue value);
        bool AddOrUpdate(TKey key, TValue value);
        void Clear();
        bool Exists(TKey key);
        TValue Get(TKey key);
        void Put(TKey key, TValue value);
        bool Remove(TKey key);
    }
}
