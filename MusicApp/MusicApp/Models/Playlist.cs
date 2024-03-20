using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Playlist
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        //Created by
        [Required]
        public string ListenerId { get; set; }
        public Listener? Listener { get; set; }

        public virtual ICollection<SongInPlaylist>? SongInPlaylist { get; set; }
        public virtual ICollection<ListenerLikesPlaylist>? LikesFromListeners { get; set; }

    }
}
