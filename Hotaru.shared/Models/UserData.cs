using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotaru.shared.Models
{
    public class UserData
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Ages { get; set; }

        public string UserID { get; set; }

        public UserData(string sName, string sEmail, string sPassword, string sPhoneNumber, string sAddress, int iAges)
        {
            Name = sName;
            Email = sEmail;
            Password = sPassword;
            PhoneNumber = sPhoneNumber;
            Address = sAddress;
            Ages = iAges;
        }

        public UserData()
        {

        }
    }
}
