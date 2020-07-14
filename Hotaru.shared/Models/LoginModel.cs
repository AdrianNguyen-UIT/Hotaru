using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotaru.shared.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
