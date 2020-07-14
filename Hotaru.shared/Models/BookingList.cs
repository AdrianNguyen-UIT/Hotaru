using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class BookingList
    {
        public List<BookingData> bookingList = new List<BookingData>();
        public BookingList(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                BookingData temp;
                if (i % 3 == 0)
                {
                    temp = new BookingData("Valley hotel", "Marcelzo" + i.ToString(), DateTime.Now, "Room for 2 people", 200000);
                }
                else if (i % 2 == 0)
                {
                    temp = new BookingData("Cathedral hotel", "Szmuel" + i.ToString(), DateTime.Now, "Room for 1 people", 100000);
                }
                else
                {
                    temp = new BookingData("Paradise hotel", "Zuonzg" + i.ToString(), DateTime.Now, "Room for 3 people", 300000);
                }
                this.bookingList.Add(temp);
            }
        }

        public BookingList()
        {

        }
    }
}
