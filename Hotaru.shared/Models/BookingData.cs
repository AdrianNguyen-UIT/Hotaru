using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class BookingData
    {
        public string HotelName { get; set; }
        public string UserName { get; set; }
        public string CustomerID { get; set; }
        public string HotelID { get; set; }
        public string StaffID { get; set; }
        public DateTime DatePickInAdvance { get; set; }
        public DateTime ReturnDateExpect { get; set; }
        public string Room_Name { get; set; }
        public int Room_Price { get; set; }

        public BookingData(string hName, string uName, DateTime date, string rName, int rPrice)
        {
            HotelName = hName;
            UserName = uName;
            DatePickInAdvance = date;
            Room_Name = rName;
            Room_Price = Room_Price;
        }
        public BookingData()
        {

        }
    }
}
