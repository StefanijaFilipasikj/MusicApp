using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class SongHasLanguage
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SongId { get; set; }
        public Song? Song { get; set; }
        public Guid LanguageId { get; set; }
        public Language? Language { get; set; }
    }
}
