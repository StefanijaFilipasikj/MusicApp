using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class ListenerLikesSong
    {
        [Key]
        public Guid Id { get; set; }
        public string ListenerId { get; set; }
        public Listener? Listener { get; set; }
        public Guid SongId { get; set; }
        public Song? Song { get; set; }
    }
}
