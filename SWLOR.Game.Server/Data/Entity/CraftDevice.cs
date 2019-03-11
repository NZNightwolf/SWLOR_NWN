
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[CraftDevice]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class CraftDevice: IEntity
    {
        public CraftDevice()
        {
            Name = "";
        }

        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
