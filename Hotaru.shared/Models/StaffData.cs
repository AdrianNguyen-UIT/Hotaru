using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class StaffData: UserData
    {
        public string HotelWork { get; set; }

        public StaffData(string sName, string sEmail, string sPassword, string sPhoneNumber, string sAddress, int iAges, string sHotel)
        {
            Name = sName;
            Email = sEmail;
            Password = sPassword;
            PhoneNumber = sPhoneNumber;
            Address = sAddress;
            Ages = iAges;
            HotelWork = sHotel;
        }
        public StaffData()
        {

        }
    }
}
