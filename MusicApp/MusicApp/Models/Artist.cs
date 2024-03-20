namespace MusicApp.Models
{
    public class Artist : User
    {
        public virtual ICollection<Album>? Albums { get; set; }
        public virtual ICollection<ListenerFollowsArtist>? Followers { get; set; }
    }
}
