using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class ListenerLikesAlbum
    {
        [Key]
        public Guid Id { get; set; }
        public string ListenerId { get; set; }
        public Listener? Listener { get; set; }
        public Guid AlbumId { get; set; }
        public Album? Album { get; set; }
    }
}
