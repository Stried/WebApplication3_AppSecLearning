using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class ApplicationUser : IdentityUser
    {
        [Required, DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required, DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required, DataType(DataType.Text)]
        public string CreditCard { get; set; }
    }
}
