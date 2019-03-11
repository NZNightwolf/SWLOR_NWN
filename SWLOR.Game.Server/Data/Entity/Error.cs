using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[Error]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class Error: IEntity
    {
        public Error()
        {
            ID = Guid.NewGuid();
        }

        [ExplicitKey]
        public Guid ID { get; set; }
        public DateTime DateCreated { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Caller { get; set; }
    }
}
