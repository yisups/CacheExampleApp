using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Core
{
    public interface ICacheProperties
    {
        int Expiration { get; set; }
    }

    public interface IMemoryCacheProperties : ICacheProperties
    {
        string Name { get; set; }
    }

    public interface IFileCacheProperties: ICacheProperties
    {
        string storage { get; set; }
    }

    public interface IDatabaseCacheProperties: ICacheProperties
    {
        string connectionString { get; set; }
    }
}
