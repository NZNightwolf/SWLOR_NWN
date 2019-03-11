

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PCSkill]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PCSkill: IEntity
    {
        public PCSkill()
        {
            ID = Guid.NewGuid();
        }
        [ExplicitKey]
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SkillID { get; set; }
        public int XP { get; set; }
        public int Rank { get; set; }
        public bool IsLocked { get; set; }
    }
}
