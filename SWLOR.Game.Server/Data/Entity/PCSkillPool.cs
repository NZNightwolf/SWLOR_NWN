using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCSkillPool]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCSkillPool: IEntity
    {
        public PCSkillPool()
        {
            ID = Guid.NewGuid();
        }

        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SkillCategoryID { get; set; }
        public int Levels { get; set; }
    }
}
