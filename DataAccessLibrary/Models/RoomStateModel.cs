using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class RoomStateModel
    {
        public int RoomState_ID { get; set; }

        public string RoomState_Name { get; set; }

        public string RoomState_Description { get; set; }

        public bool RoomState_Marked { get; set; }

        public int Hotel_ID { get; set; }
    }
}
