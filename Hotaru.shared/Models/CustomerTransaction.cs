using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class CustomerTransaction
    {
        public string HotelName { get; set; }

        public string CustomerName { get; set; }

        public string CustomerID { get; set; }

        public string HotelID { get; set; }

        public string StaffID { get; set; }

        public string AccountingName { get; set; }

        public DateTime DatePickInAdvance { get; set; }

        public DateTime DateReturn { get; set; }

        public DateTime TransactionDate { get; set; }

        public string Room_Name { get; set; }

        public int Room_Price { get; set; }

        public string AddtionalFeeDescription { get; set; }

        public int AddtionalFee { get; set; }

        public int BillPrice { get; set; }
        public CustomerTransaction(string userName,string hName, string uName, DateTime datePIA, DateTime dateR, DateTime Tdate, string rName, int rPrice, string aFD, int aF)
        {
            CustomerName = userName;
            HotelName = hName;
            AccountingName = uName;
            DatePickInAdvance = datePIA;
            DateReturn = dateR;
            TransactionDate = Tdate;
            Room_Name = rName;
            Room_Price = rPrice;
            AddtionalFeeDescription = aFD;
            AddtionalFee = aF;
            BillPrice = billPriceAccounting();
        }
        public CustomerTransaction()
        {

        }

        public int billPriceAccounting()
        {
            int i = (DateReturn - DatePickInAdvance).Days;           
            return (i * Room_Price + AddtionalFee);
        }
    }
}
