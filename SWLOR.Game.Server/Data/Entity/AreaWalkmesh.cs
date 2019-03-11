using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[AreaWalkmesh]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class AreaWalkmesh: IEntity
    {
        public AreaWalkmesh()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey] 
        public Guid ID { get; set; }
        public Guid AreaID { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
    }
}
