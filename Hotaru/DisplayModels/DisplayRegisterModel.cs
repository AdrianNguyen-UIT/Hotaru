using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Hotaru.DisplayModels
{
    public class DisplayRegisterModel
    {
        [Required]
        public string User_FirstName { get; set; }

        [Required]
        public string User_LastName { get; set; }

        [Required]
        public string User_PhoneNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please Enter your Email")]
        public string User_EmailAddress { get; set; }

        [Required]
        public string User_Gender { get; set; }

        [Required]
        public DateTime User_Birthday { get; set; }

        [Required]
        public string User_UserName { get; set; }

        [Required]
        public string User_Password { get; set; }

        [Required]
        [Compare(nameof(User_Password), ErrorMessage = "Password mismatch")]
        public string User_ConfirmPassword { get; set; }
    }
}
