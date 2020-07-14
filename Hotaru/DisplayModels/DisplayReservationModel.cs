using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotaru.DisplayModels
{
    public class DisplayReservationModel
    {
        public string Hotel_Name { get; set; }
        public string User_UserName { get; set; }
        public string CustomerID { get; set; }
        public string HotelID { get; set; }
        public string StaffID { get; set; }
        public DateTime DatePickInAdvance { get; set; }
        public DateTime ReturnDateExpect { get; set; }
        public string Room_Name { get; set; }
        public int Room_Price { get; set; }
    }
}
