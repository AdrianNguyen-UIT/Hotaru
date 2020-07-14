using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class RoomTypeModel
    {
        public int RoomType_ID { get; set; }

        public string RoomType_Name { get; set; }

        public string RoomType_BedType { get; set; }

        public int RoomType_NumberOfBed { get; set; }

        public int RoomType_Capacity { get; set; }

        public SqlMoney RoomType_Price { get; set; }

        public int Hotel_ID { get; set; }
    }
}
