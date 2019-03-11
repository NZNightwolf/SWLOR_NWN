
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[PerkLevel]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class PerkLevel: IEntity
    {
        public PerkLevel()
        {
            Description = "";
        }

        [Key]
        public int ID { get; set; }
        public int PerkID { get; set; }
        public int Level { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
