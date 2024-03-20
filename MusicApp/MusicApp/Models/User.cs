using Microsoft.AspNetCore.Identity;

namespace MusicApp.Models
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
