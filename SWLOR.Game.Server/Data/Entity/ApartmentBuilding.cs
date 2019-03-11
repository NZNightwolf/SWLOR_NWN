
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[ApartmentBuilding]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ApartmentBuilding: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
