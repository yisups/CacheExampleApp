using System;

namespace Cache.Core.Events
{
    public class CacheEventArgs<TKey> : EventArgs
    {
        protected TKey key;

        public CacheEventArgs(TKey key)
        {
            if(key != null)
                this.key = key;
            else
                throw new ArgumentException("Key must not be empty");

        }
    }
}