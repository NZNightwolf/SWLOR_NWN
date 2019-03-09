using System;
using System.Collections.Generic;
using System.Linq;
using SWLOR.Game.Server.Data.Contracts;
using SWLOR.Game.Server.Provider.Contracts;

namespace SWLOR.Game.Server.Provider
{
    public class MemoryCacheProvider: ICacheProvider
    {

        public Dictionary<Type, Dictionary<object, object>> Cache { get; }


        public MemoryCacheProvider()
        {
            Cache = new Dictionary<Type, Dictionary<object, object>>();
        }

        public void Initialize()
        {
            // No additional work needed for the in-memory cache.
            Console.WriteLine("Memory cache initialized.");
        }

        public void RegisterEmptyCacheSet<T>()
            where T: class, IEntity
        {
            var cachedSet = new Dictionary<object, object>();
            Cache.Add(typeof(T), cachedSet);

        }

        public bool IsRegistered<T>()
            where T : class, IEntity
        {
            return Cache.ContainsKey(typeof(T));
        }

        public bool IsRegistered(Type type)
        {
            return Cache.ContainsKey(type);
        }

        public void Remove<T>(object key)
            where T : class, IEntity
        {
            if (!IsRegistered<T>()) return;

            Remove(typeof(T), key);
        }

        public void Remove(Type type, object key)
        {
            if (!IsRegistered(type)) return;

            var cachedSet = Cache[type];

            if (cachedSet.ContainsKey(key))
            {
                cachedSet.Remove(key);
            }
        }

        public T Get<T>(object key)
            where T : class, IEntity
        {
            if (!Cache.TryGetValue(typeof(T), out var cachedSet))
            {
                cachedSet = new Dictionary<object, object>();
                Cache.Add(typeof(T), cachedSet);
            }

            if (cachedSet.TryGetValue(key, out object cachedObject))
            {
                return (T)cachedObject;
            }

            return default(T);
        }

        public IEnumerable<T> GetAll<T>() 
            where T : class, IEntity
        {
            if (Cache.TryGetValue(typeof(T), out var set))
            {
                return new HashSet<T>(set.Values.Cast<T>());
            }

            // If there's no data in the cache for that object type, return an empty hashset.
            return new HashSet<T>();
        }

        public void Set<T>(object key, object value)
            where T : class, IEntity
        {
            Set(typeof(T), key, value);
        }

        public void Set(Type type, object key, object value)
        {
            if (!type.GetInterfaces().Contains(typeof(IEntity)))
                throw new ArgumentException("Only objects which implement " + nameof(IEntity) + " may be set into the cache.");

            if (!Cache.TryGetValue(type, out var cachedSet))
            {
                cachedSet = new Dictionary<object, object>();
                Cache.Add(type, cachedSet);
            }

            // Safety check to ensure all key types are the same for a given type.
            if (cachedSet.Count > 0)
            {
                var first = cachedSet.Keys.First();
                if (first.GetType() != key.GetType())
                {
                    throw new Exception("Cannot set key of type " + key.GetType() + " into cache because the established type is already defined as " + first.GetType());
                }
            }

            if (cachedSet.ContainsKey(key))
            {
                cachedSet[key] = value;
            }
            else
            {
                cachedSet.Add(key, value);
            }
        }
    }
}
