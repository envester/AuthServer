using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{

    public class LoginUserDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password Should Be At least 6 characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
    public class UserDTO : LoginUserDTO
    {
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password Should Be At least 6 characters", MinimumLength =6)]
        public string Password { get; set; }

        public ICollection<string> Roles { get; set; }
    }
}
