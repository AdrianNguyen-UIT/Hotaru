using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class RoomModel
    {
        public int Room_ID { get; set; }

        public string Room_Number { get; set; }

        public int RoomType_ID { get; set; }

        public int RoomState_ID { get; set; }

        public int Hotel_ID { get; set; }

    }
}
