
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[SpaceEncounter]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class SpaceEncounter: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Planet { get; set; }
        public int Type { get; set; }
        public int Chance { get; set; }
        public int Difficulty { get; set; }
        public int LootTable { get; set; }
    }
}
