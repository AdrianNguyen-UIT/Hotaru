using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotaru.shared.Models
{
    public class RegisterModel
    {

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password),ErrorMessage = "Password mismatch")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

    }
}
