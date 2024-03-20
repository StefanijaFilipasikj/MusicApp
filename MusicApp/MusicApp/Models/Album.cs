using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Album
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string AlbumCoverUrl { get; set; }

        [Required]
        public string ArtistId { get; set; }
        public Artist? Artist { get; set; }

        public virtual ICollection<Song>? Songs { get; set; }
        public virtual ICollection<ListenerLikesAlbum>? LikesFromListeners { get; set; }
    }
}
