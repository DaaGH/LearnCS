<<<<<<< HEAD
﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace Homework11
    {
        class Consultant : BankClient
        {                      
            public int countConsul = 0;
            public DateTime dateTimeModifyC = new DateTime();
            public void SetPhoneNumber(BankClient client)
            {
                Setphonenumber(client);
                countConsul++;
                dateTimeModifyC = DateTime.Now;
            }

            public void GetInfoConsultant(BankClient client)
            {
               GetInfo(client);
            }

    }
}


=======
﻿    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace Homework11
    {
        class Consultant : BankClient
        {                      
            public int countConsul = 0;
            public DateTime dateTimeModifyC = new DateTime();
            public void SetPhoneNumber(BankClient client)
            {
                Setphonenumber(client);
                countConsul++;
                dateTimeModifyC = DateTime.Now;
            }

            public void GetInfoConsultant(BankClient client)
            {
               GetInfo(client);
            }

    }
}


>>>>>>> origin
