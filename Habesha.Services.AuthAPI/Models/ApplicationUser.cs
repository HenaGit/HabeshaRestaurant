using Microsoft.AspNetCore.Identity;

namespace Habesha.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
