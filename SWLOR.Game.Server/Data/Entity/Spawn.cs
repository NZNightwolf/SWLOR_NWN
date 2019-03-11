
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[Spawn]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class Spawn: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int SpawnObjectTypeID { get; set; }
    }
}
