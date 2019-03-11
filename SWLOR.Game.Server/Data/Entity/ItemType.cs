

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[ItemType]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ItemType: IEntity
    {
        public ItemType()
        {
            Name = "";
        }

        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
