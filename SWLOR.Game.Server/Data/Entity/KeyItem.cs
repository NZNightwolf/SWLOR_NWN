
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[KeyItem]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class KeyItem: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public int KeyItemCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
