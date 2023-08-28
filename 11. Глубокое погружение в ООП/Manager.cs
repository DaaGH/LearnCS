using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Manager : Consultant
    {
        public int countFN = 0;
        public int countLN = 0;
        public int countP = 0;
        public int countPass = 0;

        public DateTime dateTimeModifyM = new DateTime();
        public void SetFirsName(BankClient client)
        {
            Setfirstname(client);
            countFN++;
            dateTimeModifyM = DateTime.Now;
          
        }
        public void SetLastName(BankClient client) 
        {
            Setlastname(client);
            countLN++;
        }
        public void SetPatronymic(BankClient client)
        {
            Setpatronymic(client);
            countP++;
        }
        public void SetPassport(BankClient client)
        {
            Setpassport(client);
            countPass++;
        }


        public void GetInfoManager(BankClient client)
        {
            GetInfoM(client);
        }
    }
 
}
