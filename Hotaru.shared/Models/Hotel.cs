using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Hotaru.shared.Models
{
    public class Hotel
    {
        public string name { get; set; }
        public string address { get; set; }
        public string imglink { get; set; }
        public string describe { get; set; }

        public List<string> RoomData_Name = new List<string>();

        public List<int> RoomData_Price = new List<int>();
        public Hotel()
        {

        }

        public Hotel(string HotelName, string HotelAddress, string Hotelimglink, string HotelDescribe)
        {
            name = HotelName;
            address = HotelAddress;
            imglink = Hotelimglink;
            describe = HotelDescribe;
            for (int i=1;i<5;i++)
            {
                string temp = "Room " + i.ToString() + " people";
                int pricetemp = 100000 * i;
                RoomData_Name.Add(temp);
                RoomData_Price.Add(pricetemp);
            }
        }
    }
}
