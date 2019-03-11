using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[Bank]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class Bank: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string AreaName { get; set; }
        public string AreaTag { get; set; }
        public string AreaResref { get; set; }
    }
}
