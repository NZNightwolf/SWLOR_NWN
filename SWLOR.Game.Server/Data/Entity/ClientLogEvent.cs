

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[ClientLogEvent]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ClientLogEvent: IEntity
    {
        public ClientLogEvent()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public int ClientLogEventTypeID { get; set; }
        public Guid? PlayerID { get; set; }
        public string CDKey { get; set; }
        public string AccountName { get; set; }
        public DateTime DateOfEvent { get; set; }
    }
}
