using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class CustomerList
    {
        public List<CustomerData> customerList = new List<CustomerData>();
        public CustomerList(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                CustomerData temp;
                if (i % 3 == 0)
                {
                    temp = new CustomerData("Bumas Elocson" + i.ToString(), "beloc@gmail.com" + i.ToString(), "12345", "065691" + i.ToString(), "1st Da Lat street", 25, "Free");
                }
                else if (i % 2 == 0)
                {
                    temp = new CustomerData("Echan Sumazire" + i.ToString(), "ecsum@gmail.com" + i.ToString(), "12345", "023642" + i.ToString(), "2nd Da Lat street", 21, "In Valley Hotel");
                }
                else
                {
                    temp = new CustomerData("Lozi Mazura" + i.ToString(), "lmazum@gmail.com" + i.ToString(), "12345", "00123" + i.ToString(), "3nd Da Lat street", 19, "Transaction Confirm");
                }
                this.customerList.Add(temp);
            }
        }

        public CustomerList()
        {

        }
    }
}
