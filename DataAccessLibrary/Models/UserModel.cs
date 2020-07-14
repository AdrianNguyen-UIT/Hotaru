using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        public int User_ID { get; set; }

        public string User_FirstName { get; set; }

        public string User_LastName { get; set; }

        public string User_PhoneNumber { get; set; }

        public string User_EmailAddress { get; set; }

        public string User_Gender { get; set; }

        public DateTime User_Birthday { get; set; }
    }
}
