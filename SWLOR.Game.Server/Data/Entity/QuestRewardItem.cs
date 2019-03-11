
using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[QuestRewardItem]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class QuestRewardItem: IEntity
    {
        [Key]
        public int ID { get; set; }
        public int QuestID { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }
    }
}
