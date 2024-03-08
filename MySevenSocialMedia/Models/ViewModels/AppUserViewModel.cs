using Microsoft.AspNetCore.Identity;

namespace MySevenSocialMedia.Models.ViewModels
{
    public class AppAppUserViewModelUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IFormFile ProfilePicture { get; set; } //Use this to Upload file 


    }
}
