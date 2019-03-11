using ProtoBuf;
using SWLOR.Game.Server.Data.Contracts;

namespace SWLOR.Game.Server.Data.Entity
{
    [Table("[JukeboxSong]")]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class JukeboxSong: IEntity
    {
        [ExplicitKey]
        public int ID { get; set; }
        public int AmbientMusicID { get; set; }
        public string FileName { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
    }
}
