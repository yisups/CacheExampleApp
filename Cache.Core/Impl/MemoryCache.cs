using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core.Impl
{
    internal class MemoryCache<TKey, TValue> : BaseCache<TKey, TValue>
    {
        private Dictionary<TKey, TValue> cache;

        public MemoryCache(IMemoryCacheProperties properties)
        {
        }
    }
}
