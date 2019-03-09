using System;
using System.Collections.Generic;
using SWLOR.Game.Server.Data.Contracts;
using SWLOR.Game.Server.Provider.Contracts;

namespace SWLOR.Game.Server.Provider
{
    public class RedisCacheProvider: ICacheProvider
    {
        public RedisCacheProvider()
        {
        }

        public void Initialize()
        {
            Console.WriteLine("Redis cache initialized.");
        }

        public void RegisterEmptyCacheSet<T>() where T : class, IEntity
        {
        }

        public bool IsRegistered<T>() where T : class, IEntity
        {
            return false;
        }

        public bool IsRegistered(Type type)
        {
            return false;
        }

        public void Remove<T>(object key) where T : class, IEntity
        {
        }

        public void Remove(Type type, object key)
        {
        }

        public T Get<T>(object key) where T : class, IEntity
        {
            return null;
        }

        public IEnumerable<T> GetAll<T>() where T : class, IEntity
        {
            yield break;
        }

        public void Set<T>(object key, object value) where T : class, IEntity
        {
        }

        public void Set(Type type, object key, object value)
        {
        }
    }
}
