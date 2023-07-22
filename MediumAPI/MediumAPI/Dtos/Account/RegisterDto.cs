using System.ComponentModel.DataAnnotations;

namespace MediumAPI.Dtos.Account
{
    public class RegisterDto
    {
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Full name must be at least {2}, and maximum {1} characters")]
        public string FullName { get; set; }
        [Required]
        [RegularExpression("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Password must be at least {2}, and maximum {1} characters")]
        public string Password { get; set; }
    }
}
