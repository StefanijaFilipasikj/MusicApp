using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class ListenerLikesPlaylist
    {
        [Key]
        public Guid Id { get; set; }
        public string ListenerId { get; set; }
        public Listener? Listener { get; set; }
        public Guid PlaylistId { get; set; }
        public Playlist? Playlist { get; set; }
    }
}
