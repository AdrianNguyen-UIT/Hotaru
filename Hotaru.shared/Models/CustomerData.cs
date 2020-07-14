using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class CustomerData: UserData
    {
        public string state { get; set; }

        public CustomerData(string sName, string sEmail, string sPassword, string sPhoneNumber, string sAddress, int iAges, string sState)
        {
            Name = sName;
            Email = sEmail;
            Password = sPassword;
            PhoneNumber = sPhoneNumber;
            Address = sAddress;
            Ages = iAges;
            state = sState;
        }
        public CustomerData()
        {

        }
    }
}
