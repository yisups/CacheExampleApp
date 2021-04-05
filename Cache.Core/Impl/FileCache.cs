using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core.Impl
{
    internal class FileCache<TKey, TValue> : BaseCache<TKey, TValue>
    {
        public FileCache(IFileCacheProperties properties)
        {
        }
    }
}
