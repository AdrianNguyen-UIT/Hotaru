using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IPaymentData
    {
        Task DeletePayment(PaymentModel payment);
        Task<List<PaymentModel>> GetPayments();
        Task InsertPayment(PaymentModel payment);
        Task UpdatePayment(PaymentModel payment);
    }
}