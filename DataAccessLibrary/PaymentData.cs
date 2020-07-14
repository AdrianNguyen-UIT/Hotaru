using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class PaymentData : IPaymentData
    {
        private readonly ISqlDataAccess db;

        public PaymentData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<List<PaymentModel>> GetPayments()
        {
            string sql = "[dbo].[SelectAllPayment]";

            return db.LoadData<PaymentModel, dynamic>(sql, new { });
        }

        public Task InsertPayment(PaymentModel payment)
        {
            string sql = "[dbo].[InsertPayment] @Payment_Date, @Payment_Pay, @Reservation_ID";

            return db.SaveData(sql, payment);
        }

        public Task UpdatePayment(PaymentModel payment)
        {
            string sql = "[dbo].[UpdatePayment] @Payment_ID, @Payment_Date, @Payment_Pay, @Reservation_ID";

            return db.SaveData(sql, payment);
        }

        public Task DeletePayment(PaymentModel payment)
        {
            string sql = "[dbo].[DeletePayment] @Payment_ID";

            return db.SaveData(sql, payment);
        }
    }
}
