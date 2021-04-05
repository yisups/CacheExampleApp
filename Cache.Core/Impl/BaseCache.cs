using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core.Impl
{
    internal abstract class BaseCache<TKey, TValue> : ICache<TKey, TValue>
    {
        public bool Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool AddOrUpdate(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Exists(TKey key)
        {
            throw new NotImplementedException();
        }

        public TValue Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Put(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            throw new NotImplementedException();
        }
    }
}
