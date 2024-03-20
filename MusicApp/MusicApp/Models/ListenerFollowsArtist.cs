using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class ListenerFollowsArtist
    {
        [Key]
        public Guid Id { get; set; }
        public string ListenerId { get; set; }
        public Listener? Listener { get; set; }
        public string ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}
