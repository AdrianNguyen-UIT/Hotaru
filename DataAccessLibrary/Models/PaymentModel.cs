using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class PaymentModel
    {
        public int Payment_ID { get; set; }

        public SqlMoney Payment_Total { get; set; }

        public DateTime Payment_Date { get; set; }

        public bool Payment_Pay { get; set; }

        public int Reservation_ID { get; set; }
    }
}
