using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core.Impl
{
    internal class DatabaseCache<TKey, TValue> : BaseCache<TKey, TValue>
    {
        public DatabaseCache(IDatabaseCacheProperties properties)
        {
        }
    }
}
