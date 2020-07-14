using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class TransactionList
    {
        public List<CustomerTransaction> transactionList = new List<CustomerTransaction>();
        public TransactionList(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    DateTime nowz = DateTime.Now;
                    DateTime nowzt = nowz.AddDays(13);
                    CustomerTransaction temp = new CustomerTransaction("Marcello","Valley hotel", "Michael", nowz, nowzt, nowzt, "Room for 1 people", 100000, "No adding fee", 0);
                    transactionList.Add(temp);
                }
                else
                {
                    DateTime nowz = DateTime.Now;
                    DateTime nowzt = nowz.AddDays(20);
                    CustomerTransaction temp = new CustomerTransaction("Some name","Yolo hotel", "Mistone", nowz, nowzt, nowzt, "Room for 3 people", 200000, "1 towel", 15000);
                    transactionList.Add(temp);
                }
            }
        }
        public TransactionList()
        {

        }
    }
}
