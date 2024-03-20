using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class SongHasGenre
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SongId { get; set; }
        public Song? Song { get; set; }
        public Guid GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
