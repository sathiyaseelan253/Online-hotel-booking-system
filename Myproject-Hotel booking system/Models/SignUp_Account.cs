using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Entity
{
    public class SignUp_Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [Required(ErrorMessage = "Username required")]
        public string userName { get; set; }
        [Required(ErrorMessage = "First name required")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Last name required")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Email required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Please retype password mismatch")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

    }
}
