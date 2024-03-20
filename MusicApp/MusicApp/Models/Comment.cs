using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Text { get; set; }

        //Written by Listener
        public string ListenerId { get; set; }
        public Listener? Listener { get; set; }

        //Written for Song
        public Guid SongId { get; set; }
        public Song? Song { get; set; }

        public Guid ParentCommentId { get; set; }
        public Comment? ParentComment { get; set; }

        public virtual ICollection<Comment>? Replies { get; set; }
    }
}
