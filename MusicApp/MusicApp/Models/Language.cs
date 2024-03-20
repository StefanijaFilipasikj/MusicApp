using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Language
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<SongHasLanguage>? Songs { get; set; }
    }
}
