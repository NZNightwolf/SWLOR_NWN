

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCRegionalFame]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCRegionalFame: IEntity
    {
        public PCRegionalFame()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int FameRegionID { get; set; }
        public int Amount { get; set; }
    }
}
