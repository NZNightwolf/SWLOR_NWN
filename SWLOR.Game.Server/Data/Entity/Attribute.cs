using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[Attribute]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class Attribute: IEntity
    {
        public Attribute()
        {
            Name = "";
        }

        [ExplicitKey]
        public int ID { get; set; }
        public int NWNValue { get; set; }
        public string Name { get; set; }
    }
}
