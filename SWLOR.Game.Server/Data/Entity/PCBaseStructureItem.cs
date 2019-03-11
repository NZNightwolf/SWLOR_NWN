
using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCBaseStructureItem]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCBaseStructureItem: IEntity
    {
        public PCBaseStructureItem()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PCBaseStructureID { get; set; }
        public string ItemGlobalID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }
    }
}
