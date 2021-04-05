using Cache.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core
{
    public interface ICacheWithEvents<TKey, TValue> : ICache<TKey, TValue>
    {
        event EventHandler<CacheEventArgs<TKey>> OnAdd;
        event EventHandler<CacheEventArgs<TKey>> OnClear;
        event EventHandler<CacheEventArgs<TKey>> OnPut;
        event EventHandler<CacheEventArgs<TKey>> OnRemove;
        event EventHandler<CacheEventArgs<TKey>> OnGet;
    }
}
