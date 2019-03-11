
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[SkillCategory]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class SkillCategory: IEntity
    {
        public SkillCategory()
        {
            Name = "";
        }

        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }
    }
}
