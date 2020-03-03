using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace User.Entity
{
    public class Login_Account
    {
        [Required(ErrorMessage ="Please enter user-name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

    }
}
