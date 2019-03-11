

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[SkillXPRequirement]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class SkillXPRequirement: IEntity
    {
        [Key]
        public int ID { get; set; }
        public int SkillID { get; set; }
        public int Rank { get; set; }
        public int XP { get; set; }
    }
}
