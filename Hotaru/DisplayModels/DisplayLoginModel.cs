using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotaru.DisplayModels
{
    public class DisplayLoginModel
    {
        [Required]
        public string Login_UserName { get; set; }

        [Required]
        public string Login_Password { get; set; }

        public int User_ID { get; set; }
    }
}
