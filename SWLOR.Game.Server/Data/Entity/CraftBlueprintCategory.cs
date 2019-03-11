
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[CraftBlueprintCategory]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class CraftBlueprintCategory: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    
    }
}
