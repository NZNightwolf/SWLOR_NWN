using System;
using System.Collections.Generic;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Provider.Contracts
{
    public interface ICacheProvider
    {
        void Initialize();
        void RegisterEmptyCacheSet<T>()
            where T: class, IEntity;
        bool IsRegistered<T>()
            where T: class, IEntity;
        bool IsRegistered(Type type);
        void Remove<T>(object key)
            where T: class, IEntity;
        void Remove(Type type, object key);
        T Get<T>(object key)
            where T: class, IEntity;
        IEnumerable<T> GetAll<T>()
            where T: class, IEntity;
        void Set<T>(object key, object value)
            where T: class, IEntity;
        void Set(Type type, object key, object value);
    }
}
