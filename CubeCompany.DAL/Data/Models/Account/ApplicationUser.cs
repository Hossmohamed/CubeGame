using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CubeGame.Data.Models.Account
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }
    }
}
