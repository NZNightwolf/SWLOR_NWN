

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCMapProgression]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCMapProgression: IEntity
    {
        public PCMapProgression()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string AreaResref { get; set; }
        public string Progression { get; set; }
    }
}
