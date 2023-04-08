using Microsoft.AspNetCore.Identity;

namespace RateMe.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Pictures = new List<Picture>();
        }

        public ICollection<Picture> Pictures { get; set; } = null!;
    }
}