using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[MarketCategory]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class MarketCategory: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
