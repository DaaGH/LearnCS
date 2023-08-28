<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class BankClient
    {
        // конструктор с параметрами ФИО, телефон, серия номер паспорта
        /// <summary>
        /// Описание клиента
        /// </summary>
        /// <param name="Firstname">Имя</param>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="Patronymic">Отчество</param>
        /// <param name="PhoneNumber">Телефон</param>
        /// <param name="Passport">Серия и номер паспорта</param>        
        public BankClient() { }
        public BankClient(string Firstname, string Lastname, string Patronymic, string PhoneNumber, string Passport)
        {
            Firstname_field = Firstname;    // присваиваем полю значение из конструктора
            Lastname_field = Lastname;
            Patronymic_field = Patronymic;
            PhoneNumber_field = PhoneNumber;
            Passport_field = Passport;

            ////Задание 3

            //Passport_field = null;
        }

        // поля класса с информацией о клиенте
        // почему private protected?

        private protected string Firstname_field;
        private protected string Lastname_field;
        private protected string Patronymic_field;
        private protected string PhoneNumber_field;
        private protected string Passport_field;

        string dataModify;  // какие данные изменены
        string typeModify;  // тип изменений добавление нового клиента или изменение в существующем
        public bool whoModify;   // кто изменил

    //public int count = 0;
    //public int count1 = 0;


    // 


    // как переопределить для менеджера, что бы доступ был полный для паспортных данных: UPD 09082023 вроде всё правильно работает
    protected void GetInfo(BankClient client)
        {
            Console.WriteLine(client.PhoneNumber_field);
            Console.WriteLine(client.Lastname_field);
            Console.WriteLine(client.Firstname_field);
            Console.WriteLine(client.Patronymic_field);
            if (client.Passport_field != String.Empty) Console.WriteLine("**********");           
        }

        protected void GetInfoM(BankClient client)
        {            
            Console.WriteLine(client.Firstname_field);
            Console.WriteLine(client.Lastname_field);
            Console.WriteLine(client.Patronymic_field);
            Console.WriteLine(client.PhoneNumber_field);
            Console.WriteLine(client.Passport_field);
        }

        protected void Setfirstname(BankClient client)
        {
            Console.WriteLine("Введите имя");
            client.Firstname_field = Console.ReadLine();
            whoModify = true;
           // count++;

        }
        protected void Setlastname(BankClient client)
        {
            Console.WriteLine("Введите фамилию");
            client.Lastname_field = Console.ReadLine();

          //  count1++;
        }

        protected void Setpatronymic(BankClient client)
        {
            Console.WriteLine("Введите отчество");
            client.Patronymic_field = Console.ReadLine();
        }       

        protected void Setpassport(BankClient client)
        {
            Console.WriteLine("Введите паспорт");
            client.Passport_field = Console.ReadLine();
        }

        protected void Setphonenumber(BankClient client)
        {
            Console.WriteLine("Введите номер телефона:");
            client.PhoneNumber_field = Console.ReadLine();
            if (String.IsNullOrEmpty(client.PhoneNumber_field)) { Console.WriteLine("необходимо ввести номер телефона"); Setphonenumber(client); }
            // String.IsNullOrEmpty(PhoneNumber_field) проверка на пустоту строки в скобках - PhoneNumber_field
        }



        /*
        public string GetPhoneNumber()
        {
            return PhoneNumber_field;
        }

        public virtual string GetLastname()
        {
            return Lastname_field;
        }
        public string GetPassport()
        {
            if (Passport_field != String.Empty) { return "**********"; }
            else return null;
        }


        // доступ к значению переменной организуем через свойство Firstname_property, которое возвращает
        // значение поля
        public string Firstname_property { get { return Firstname_field; } }
        public string Lastname_property { get { return Lastname_field; } }
        public string Patronymic_property { get { return Patronymic_field; } }
        // return "" ничего не выводит! потому, если нет паспорта, то и не выведет ничего
        public string Passport_property { get { if (Passport_field != String.Empty) return "**********"; return ""; } }

        public string PhoneNumber_property { get { return PhoneNumber_field; } }

        /*
        public void SetFirstname(string name) { 
            Firstname_field = name;
        }
        */

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class BankClient
    {
        // конструктор с параметрами ФИО, телефон, серия номер паспорта
        /// <summary>
        /// Описание клиента
        /// </summary>
        /// <param name="Firstname">Имя</param>
        /// <param name="Lastname">Фамилия</param>
        /// <param name="Patronymic">Отчество</param>
        /// <param name="PhoneNumber">Телефон</param>
        /// <param name="Passport">Серия и номер паспорта</param>        
        public BankClient() { }
        public BankClient(string Firstname, string Lastname, string Patronymic, string PhoneNumber, string Passport)
        {
            Firstname_field = Firstname;    // присваиваем полю значение из конструктора
            Lastname_field = Lastname;
            Patronymic_field = Patronymic;
            PhoneNumber_field = PhoneNumber;
            Passport_field = Passport;

            ////Задание 3

            //Passport_field = null;
        }

        // поля класса с информацией о клиенте
        // почему private protected?

        private protected string Firstname_field;
        private protected string Lastname_field;
        private protected string Patronymic_field;
        private protected string PhoneNumber_field;
        private protected string Passport_field;

        string dataModify;  // какие данные изменены
        string typeModify;  // тип изменений добавление нового клиента или изменение в существующем
        public bool whoModify;   // кто изменил

    //public int count = 0;
    //public int count1 = 0;


    // 


    // как переопределить для менеджера, что бы доступ был полный для паспортных данных: UPD 09082023 вроде всё правильно работает
    protected void GetInfo(BankClient client)
        {
            Console.WriteLine(client.PhoneNumber_field);
            Console.WriteLine(client.Lastname_field);
            Console.WriteLine(client.Firstname_field);
            Console.WriteLine(client.Patronymic_field);
            if (client.Passport_field != String.Empty) Console.WriteLine("**********");           
        }

        protected void GetInfoM(BankClient client)
        {            
            Console.WriteLine(client.Firstname_field);
            Console.WriteLine(client.Lastname_field);
            Console.WriteLine(client.Patronymic_field);
            Console.WriteLine(client.PhoneNumber_field);
            Console.WriteLine(client.Passport_field);
        }

        protected void Setfirstname(BankClient client)
        {
            Console.WriteLine("Введите имя");
            client.Firstname_field = Console.ReadLine();
            whoModify = true;
           // count++;

        }
        protected void Setlastname(BankClient client)
        {
            Console.WriteLine("Введите фамилию");
            client.Lastname_field = Console.ReadLine();

          //  count1++;
        }

        protected void Setpatronymic(BankClient client)
        {
            Console.WriteLine("Введите отчество");
            client.Patronymic_field = Console.ReadLine();
        }       

        protected void Setpassport(BankClient client)
        {
            Console.WriteLine("Введите паспорт");
            client.Passport_field = Console.ReadLine();
        }

        protected void Setphonenumber(BankClient client)
        {
            Console.WriteLine("Введите номер телефона:");
            client.PhoneNumber_field = Console.ReadLine();
            if (String.IsNullOrEmpty(client.PhoneNumber_field)) { Console.WriteLine("необходимо ввести номер телефона"); Setphonenumber(client); }
            // String.IsNullOrEmpty(PhoneNumber_field) проверка на пустоту строки в скобках - PhoneNumber_field
        }



        /*
        public string GetPhoneNumber()
        {
            return PhoneNumber_field;
        }

        public virtual string GetLastname()
        {
            return Lastname_field;
        }
        public string GetPassport()
        {
            if (Passport_field != String.Empty) { return "**********"; }
            else return null;
        }


        // доступ к значению переменной организуем через свойство Firstname_property, которое возвращает
        // значение поля
        public string Firstname_property { get { return Firstname_field; } }
        public string Lastname_property { get { return Lastname_field; } }
        public string Patronymic_property { get { return Patronymic_field; } }
        // return "" ничего не выводит! потому, если нет паспорта, то и не выведет ничего
        public string Passport_property { get { if (Passport_field != String.Empty) return "**********"; return ""; } }

        public string PhoneNumber_property { get { return PhoneNumber_field; } }

        /*
        public void SetFirstname(string name) { 
            Firstname_field = name;
        }
        */

    }
}
>>>>>>> origin
