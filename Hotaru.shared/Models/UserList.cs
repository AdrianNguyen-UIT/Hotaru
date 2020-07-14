using System;
using System.Collections.Generic;
using System.Text;

namespace Hotaru.shared.Models
{
    public class UserList
    {
        public List<UserData> userList = new List<UserData>();
        public UserList(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                UserData temp;
                if (i % 3 == 0)
                {
                    temp = new UserData("Bumas Elocson" + i.ToString(), "beloc@gmail.com" + i.ToString(), "12345", "065691" + i.ToString(),"1st Da Lat street", 25);
                }
                else if (i % 2 == 0)
                {
                    temp = new UserData("Echan Sumazire" + i.ToString(), "ecsum@gmail.com" + i.ToString(), "12345", "023642" + i.ToString(), "2nd Da Lat street", 21);
                }
                else
                {
                    temp = new UserData("Lozi Mazura" + i.ToString(), "lmazum@gmail.com" + i.ToString(), "12345", "00123" + i.ToString(), "3nd Da Lat street", 19);
                }
                this.userList.Add(temp);
            }
        }

        public UserList()
        {

        }
    }
}
