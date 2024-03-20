using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<SongHasGenre>? Songs { get; set; }
    }
}
