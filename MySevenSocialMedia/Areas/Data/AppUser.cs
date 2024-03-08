using Microsoft.AspNetCore.Identity;

namespace MySevenSocialMedia.Areas.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
    }
}
