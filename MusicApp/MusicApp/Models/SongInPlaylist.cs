using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class SongInPlaylist
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SongId { get; set; }
        public Song? Song { get; set; }
        public Guid PlaylistId { get; set; }
        public Playlist? Playlist { get; set; }
    }
}
