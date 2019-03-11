using System;
using System.Collections.Generic;
using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[CustomEffect]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class CustomEffect: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public string Name { get; set; }
        public int IconID { get; set; }
        public string ScriptHandler { get; set; }
        public string StartMessage { get; set; }
        public string ContinueMessage { get; set; }
        public string WornOffMessage { get; set; }
        public int CustomEffectCategoryID { get; set; }
    }
}
