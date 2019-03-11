

using System;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[QuestPrerequisite]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class QuestPrerequisite: IEntity
    {
        [Key]
        public int ID { get; set; }
        public int QuestID { get; set; }
        public int RequiredQuestID { get; set; }
    }
}
