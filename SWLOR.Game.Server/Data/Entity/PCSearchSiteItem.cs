

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCSearchSiteItem]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCSearchSiteItem: IEntity
    {
        public PCSearchSiteItem()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SearchSiteID { get; set; }
        public string SearchItem { get; set; }
    }
}
