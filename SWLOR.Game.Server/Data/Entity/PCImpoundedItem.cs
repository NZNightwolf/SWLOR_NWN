
using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCImpoundedItem]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCImpoundedItem: IEntity
    {
        public PCImpoundedItem()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }
        public DateTime DateImpounded { get; set; }
        public DateTime? DateRetrieved { get; set; }
    
    }
}
