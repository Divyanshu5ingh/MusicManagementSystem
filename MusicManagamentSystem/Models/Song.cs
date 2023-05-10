using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MusicManagamentSystem.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public string Singers { get; set; }
        public int PlaylistId { get; set; }

        [JsonIgnore]
        public virtual Playlist? Playlist { get; set; }
    }
}
