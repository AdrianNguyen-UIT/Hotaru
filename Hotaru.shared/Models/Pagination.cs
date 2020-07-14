using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class Pagination
    {
        public int MaxPages { get; set; }
        public int ObjectEachPage { get; set; }
        public int MaxObject { get; set;}
        public Pagination(int MO,int OEP)
        {
            MaxObject = MO;
            ObjectEachPage = OEP;
            if (MO % OEP != 0) MaxPages = MO / OEP + 1;
            else MaxPages = MO / OEP;
        }
    }
}
