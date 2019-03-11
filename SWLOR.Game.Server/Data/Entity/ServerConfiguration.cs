

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[ServerConfiguration]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ServerConfiguration: IEntity
    {
        public ServerConfiguration()
        {
            ServerName = "";
            MessageOfTheDay = "";
        }

        [ExplicitKey]
        public int ID { get; set; }
        public string ServerName { get; set; }
        public string MessageOfTheDay { get; set; }
        public int AreaBakeStep { get; set; }
    }
}
