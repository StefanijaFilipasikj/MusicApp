namespace MusicApp.Models
{
    public class Listener : User
    {
        public virtual ICollection<ListenerFollowsArtist>? Following { get; set; }
        public virtual ICollection<ListenerLikesSong>? LikedSongs { get; set; }
        public virtual ICollection<ListenerLikesAlbum>? LikedAlbums { get; set; }
        public virtual ICollection<ListenerLikesPlaylist>? LikedPlaylists { get; set; }
        public virtual ICollection<Playlist>? CreatedPlaylists { get; set; }
        public virtual ICollection<Comment>? WrittenComments { get; set; }
    }
}
