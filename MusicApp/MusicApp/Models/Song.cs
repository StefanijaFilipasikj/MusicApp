using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Song
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Lyrics { get; set; }
        [Required]
        public string AudioUrl { get; set; }
        [Required]
        public string VideoUrl { get; set; }

        [Required]
        public Guid AlbumId { get; set; }
        public Album? Album { get; set; }

        public virtual ICollection<SongHasGenre>? SongGenres { get; set; }
        public virtual ICollection<SongHasLanguage>? SongLanguages { get; set; }
        public virtual ICollection<ListenerLikesSong>? LikesFromListeners { get; set; }
        public virtual ICollection<SongInPlaylist>? SongInPlaylist { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
