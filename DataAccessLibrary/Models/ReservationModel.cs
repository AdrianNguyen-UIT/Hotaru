using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ReservationModel
    {
        public int Reservation_ID { get; set; }

        public DateTime Reservation_ReserveDate { get; set; }

        public DateTime Reservation_StartDate { get; set; }

        public DateTime Reservation_EndDate { get; set; }

        public int Room_ID { get; set; }

        public int Hotel_ID { get; set; }

        public int User_ID { get; set; }

        public string Reservation_Description { get; set; }
    }
}
