using ProtoBuf;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[DMActionType]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class DMActionType
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
