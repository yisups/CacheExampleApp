using Cache.Core.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core
{
    public enum CacheType
    {
        File, 
        Database,
        Memory,
    }

    public static class CacheFactory
    {
        private static object _instance = null;

        public static ICache<TKey, TValue> GetCache<TKey, TValue>(CacheType type, ICacheProperties properties)
        {
            ICache<TKey, TValue> cache = null;

            if (_instance != null)
                cache = (ICache<TKey, TValue>) _instance;
            else
            {
                switch(type)
                {
                    case CacheType.File:
                        {
                            if (properties is IFileCacheProperties)
                            {
                                cache = new FileCache<TKey, TValue>((IFileCacheProperties)properties);
                            }
                            else
                            {
                                throw new ArgumentException("Properties argument must implement IFileCacheProperties");
                            }
                            break;
                        }
                    case CacheType.Memory:
                        {
                            if (properties is IMemoryCacheProperties)
                            {
                                cache = new MemoryCache<TKey, TValue>((IMemoryCacheProperties)properties);
                            }
                            else
                            {
                                throw new ArgumentException("Properties argument must implement IMemoryCacheProperties");
                            }
                            break;
                        }
                    case CacheType.Database:
                        {
                            if (properties is IDatabaseCacheProperties)
                            {
                                cache = new DatabaseCache<TKey, TValue>((IDatabaseCacheProperties)properties);
                            }
                            else
                            {
                                throw new ArgumentException("Properties argument must implement IDatabaseCacheProperties");
                            }
                            break;
                        }
                    default:
                        {
                            throw new System.ComponentModel.InvalidEnumArgumentException("Cache not supported");
                        }
                }

            }

            return cache;
        }
    }
}
