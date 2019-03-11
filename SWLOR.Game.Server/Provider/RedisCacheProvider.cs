using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProtoBuf;
using StackExchange.Redis;
using SWLOR.Game.Server.Data.Contracts;
using SWLOR.Game.Server.NWNX.Contracts;
using SWLOR.Game.Server.Provider.Contracts;

namespace SWLOR.Game.Server.Provider
{
    public class RedisCacheProvider: ICacheProvider
    {
        private ConnectionMultiplexer _redis;
        private string _ip;
        private readonly INWNXAdmin _nwnxAdmin;

        public RedisCacheProvider(INWNXAdmin nwnxAdmin)
        {
            _nwnxAdmin = nwnxAdmin;
        }

        public void Initialize()
        {
            // Look for the Redis IP address environment variable.
            _ip = Environment.GetEnvironmentVariable("REDIS_SERVER_IP_ADDRESS");
            if (string.IsNullOrWhiteSpace(_ip))
            {
                // Couldn't find an IP address for the Redis server. Notify the user.
                Console.WriteLine("ERROR: IP Address not set for Redis cache. You must specify REDIS_SERVER_IP_ADDRESS in your environment variables.");
            }

            // Attempt the connection.
            try
            {
                // We must allow admin to ensure the cache gets cleared and rebuilt from scratch. 
                _redis = ConnectionMultiplexer.Connect(_ip + ",allowAdmin=true");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Couldn't connect to the Redis cache. Reason: " + ex.Message);
                Console.WriteLine("Server will shut down now.");
                _nwnxAdmin.ShutdownServer();
                return;
            }
            // Flush the cache. We want to do this on every server boot up so we're not getting stale data.
            var server = _redis.GetServer(_ip);
            server.FlushDatabase();
            Console.WriteLine("Redis cache initialized.");
        }

        //private static string SerializeSet(Dictionary<object, object> set)
        //{
        //    return JsonConvert.SerializeObject(set);
        //}

        private static byte[] SerializeSet(Dictionary<object, object> set)
        {
            byte[] result;
            using (MemoryStream stream = new MemoryStream())
            {
                Serializer.Serialize(stream, set);
                result = stream.ToArray();
            }

            return result;
        }

        private Dictionary<object, object> DeserializeSet(string cacheKey)
        {
            var db = _redis.GetDatabase();
            var serialized = db.StringGet(cacheKey);
            Dictionary<object, object> cacheSet;// = JsonConvert.DeserializeObject<Dictionary<object, object>>(serialized);
            using (MemoryStream stream = new MemoryStream(serialized))
            {
                cacheSet = Serializer.Deserialize<Dictionary<object, object>>(stream);
            }

            return cacheSet;
        }

        public void RegisterEmptyCacheSet<T>() 
            where T : class, IEntity
        {
            var key = typeof(T).ToString();
            var cachedSet = new Dictionary<object, object>();
            var data = SerializeSet(cachedSet);
            var db = _redis.GetDatabase();
            db.StringSet(key, data);

        }

        public bool IsRegistered<T>() 
            where T : class, IEntity
        {
            var key = typeof(T).ToString();
            var db = _redis.GetDatabase();
            return db.KeyExists(key);
        }

        public bool IsRegistered(Type type)
        {
            var key = type.ToString();
            var db = _redis.GetDatabase();
            return db.KeyExists(key);
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

            var cacheKey = type.ToString();
            var db = _redis.GetDatabase();
            var cacheSet = DeserializeSet(cacheKey);

            if (cacheSet.ContainsKey(key))
            {
                cacheSet.Remove(key);
                var serialized = SerializeSet(cacheSet);
                db.StringSet(cacheKey, serialized);
            }
        }

        public T Get<T>(object key) 
            where T : class, IEntity
        {
            var cacheKey = typeof(T).ToString();
            var db = _redis.GetDatabase();
            var cacheSet = new Dictionary<object, object>();
            
            if (!db.KeyExists(cacheKey))
            {
                var serialized = SerializeSet(cacheSet);
                db.StringSet(cacheKey, serialized);
            }

            cacheSet = DeserializeSet(cacheKey);

            if (cacheSet.TryGetValue(key, out object cachedObject))
            {
                return (T) cachedObject;
            }

            return default(T);
        }

        public IEnumerable<T> GetAll<T>() 
            where T : class, IEntity
        {
            var cacheKey = typeof(T).ToString();
            var db = _redis.GetDatabase();
            if (db.KeyExists(cacheKey))
            {
                var cacheSet = DeserializeSet(cacheKey);
                return new HashSet<T>(cacheSet.Values.Cast<T>());
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


            Console.WriteLine("type set = " + type.ToString());
            Console.WriteLine("key type: " + key.GetType());

            var cacheKey = type.ToString();
            var db = _redis.GetDatabase();
            var cacheSet = new Dictionary<object, object>();
            byte[] serialized;
            if (!db.KeyExists(cacheKey))
            {
                serialized = SerializeSet(cacheSet);
                db.StringSet(cacheKey, serialized);
            }

            cacheSet = DeserializeSet(cacheKey);

            // Safety check to ensure all key types are the same for a given type.
            if (cacheSet.Count > 0)
            {
                var first = cacheSet.Keys.First();
                if (first.GetType() != key.GetType())
                {
                    Console.WriteLine("unmatch. value = " + first);

                    throw new Exception("Cannot set key of type " + key.GetType() + " into cache because the established type is already defined as " + first.GetType());
                }
            }

            if (cacheSet.ContainsKey(key))
            {
                cacheSet[key] = value;
            }
            else
            {
                Console.WriteLine("key value = " + key);
                cacheSet.Add(key, value);
            }

            serialized = SerializeSet(cacheSet);
            db.StringSet(cacheKey, serialized);
        }
    }
}
