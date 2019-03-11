
using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCCraftedBlueprint]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCCraftedBlueprint: IEntity
    {
        public PCCraftedBlueprint()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int CraftBlueprintID { get; set; }
        public DateTime DateFirstCrafted { get; set; }
    }
}
