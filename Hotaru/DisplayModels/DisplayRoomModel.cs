using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace Hotaru.DisplayModels
{
    public class DisplayRoomModel
    {
        public string Room_ID { get; set; }

        [Required]
        public string Room_Number { get; set; }

        [Required]
        public string RoomType_ID { get; set; }

        [Required]
        public string RoomState_ID { get; set; }

    }
}
