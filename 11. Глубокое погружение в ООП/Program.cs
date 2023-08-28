<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework11
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = { "Виктор", "Гудман", "Яковлевич", "89995554422", "3426 293846" };
            string[] arr2 = { "Игорь", "Иванов", "Петрович", "79995554422", String.Empty };



            List<BankClient> dbNames;
            dbNames = new List<BankClient>();
            // создаём двух клиентов
            BankClient Client1 = new BankClient("Виктор", "Гудман", "Яковлевич", "89995554422", "3426 293846");
            BankClient Client2 = new BankClient("Игорь", "Иванов", "Петрович", "79995554422", String.Empty);
            

            // добавляем их в базу                                  
            dbNames.Add(Client1);
            dbNames.Add(Client2);
            ////////////////////////////Задание 3 

            //Добавить в BankClient виртуальный метод изменения данных, который будет разный для Consultant и Manager?
            //В методе добавить выбор какие данные изменять?? Какой-то счётчик? Если больше 0, то изменены.



            //////////////////////////////////////

            int choice;
            do
            {
                Console.WriteLine("Выберите, кто работает с данными:\n" +
                    "1 - Менеджер\n" +
                    "2 - Консультант\n" +
                    "0 - Выход");
                int change = Convert.ToInt32(Console.ReadLine());
                choice = change;
                if (change == 1)
                {
                    Console.WriteLine("Работает менеджер");


                    Manager Manager = new Manager();
                    int func1;
                    do
                    {
                        Console.WriteLine("1 - Изменить имя\n" +
                            "2 - Изменить фамилию\n" +
                            "3 - Изменить отчество\n" +
                            "4 - Изменить паспортные данные\n" +
                            "5 - Вывести информацию на экран\n" +
                            "0 - Выход в предыдущее меню");
                        int func = Convert.ToInt32(Console.ReadLine());
                        func1 = func;
                        switch (func)
                        {
                            case 1:
                                Console.WriteLine("Выберите номер клиента имя которого хотите изменить");

                                int numOfClient = Convert.ToInt32(Console.ReadLine());

                                Manager.SetFirsName(dbNames[numOfClient]);
                                
                                break;
                            case 2:
                                Manager.SetLastName(Client2);
                                break;
                            case 3:
                                Manager.SetPatronymic(Client2);
                                break;
                            case 4:
                                Manager.SetPassport(Client2);
                                break;
                            case 5:
                                
                                Console.WriteLine("Менеджер получает информацию о всех клиентах");

                                foreach (var a in dbNames)
                                {
                                    Manager.GetInfoConsultant(a);
                                }
                                Console.WriteLine("Менеджер получает информацию об одном клиенте");
                                Manager.GetInfoManager(Client2);

                                Console.WriteLine("Выберите номер клиента информацию о котором хотите вывести");
                                
                                int numOfClient1 = Convert.ToInt32(Console.ReadLine());
                                Manager.GetInfoManager(dbNames[numOfClient1]);
                                break;
                        }
                    } while (func1 != 0);
                    //
                    if (Manager.countFN > 0)
                    {
                        Console.WriteLine($"Менеждер изменил имя в {Manager.dateTimeModifyM}");
                    }
                    if (Manager.countLN > 0)
                    {
                        Console.WriteLine($"Менеждер изменил фамилию в {Manager.dateTimeModifyM}");
                    }
                    if (Manager.countP > 0)
                    {
                        Console.WriteLine($"Менеждер изменил отчество в {Manager.dateTimeModifyM}");
                    }
                    if (Manager.countPass > 0)
                    {
                        Console.WriteLine($"Менеждер изменил паспорт в {Manager.dateTimeModifyM}");
                    }
                }
                if (change == 2)
                {

                    Console.WriteLine("Работает консультант");

                    Consultant Consultant = new Consultant();
                    
                    Console.WriteLine("Консультант получает информацию о всех клиентах");
                    foreach (var a in dbNames) {
                        Consultant.GetInfoConsultant(a);
                    }

                    //Console.WriteLine("Консультант получает информацию");
                    //Consultant.GetInfoConsultant(Client1);
                    //Consultant.GetInfoConsultant(Client2);

                    Consultant.SetPhoneNumber(Client1);
                    if (Consultant.countConsul > 0)
                    {
                        Console.WriteLine($"Консультант изменил номер телефона в {Consultant.dateTimeModifyC}");
                    }

                }
            }while(choice != 0);

           

           
            
            //dateTimeModifyC = DateTime.Now;

            //else if (Manager.count1 > 0) {
            //    Console.WriteLine("Изменена фамилия");
            //}
            // 09082023 закрыл отладку
            /*
            Consultant.GetInfoConsultant(Client2);

            Consultant.SetPhoneNumber(Client2);
            
            Consultant.GetInfoConsultant(Client2);
            Console.WriteLine();
            
            Manager.SetFirsName(Client2);
            Manager.SetLastName(Client2);
            Manager.SetPatronymic(Client2);
            Manager.SetPhoneNumber(Client2);
            Manager.SetPassport(Client2);*/
                    
         


            //Client2.GetInfo();


            // выводим информацию о клиентах через консультанта
            //Consultant.ReadClientInfo(dbNames[1]);

            //Consultant.ReadClientInfo(dbNames[0]);

            //Consultant.Firstname_property = "dsfsd";


            //Consultant.ReadClientInfo(dbNames[0]);
            // 
            //Consultant.SetPhoneNumber(dbNames[0]);

            //Consultant.ReadClientInfo(dbNames[0]);

            //Console.WriteLine(Client2.Passport_property);
            // Console.WriteLine(Client2.Passport_property);

            //Console.WriteLine(Consultant.Passport_property);

            //Console.Write(Consultant.GetPassport());

            //Manager.setI("Смирнов");
            //Console.WriteLine(Manager.Lastname_property);


            //for (int i = 0; i < dbNames.Count; i++) {
            //   Consultant1.readClientInfo(dbNames[i]);
            //}

            /*
              if (String.IsNullOrEmpty(Client1.Passport_property));
              else Console.WriteLine(Client1.Passport_property);

              //Console.WriteLine(Client1.GetPassport());

              //Client1.SetPhoneNumber();

              Console.WriteLine(Client1.GetPhoneNumber());
              */

          
          

        }
    }



=======
﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework11
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = { "Виктор", "Гудман", "Яковлевич", "89995554422", "3426 293846" };
            string[] arr2 = { "Игорь", "Иванов", "Петрович", "79995554422", String.Empty };



            List<BankClient> dbNames;
            dbNames = new List<BankClient>();
            // создаём двух клиентов
            BankClient Client1 = new BankClient("Виктор", "Гудман", "Яковлевич", "89995554422", "3426 293846");
            BankClient Client2 = new BankClient("Игорь", "Иванов", "Петрович", "79995554422", String.Empty);
            

            // добавляем их в базу                                  
            dbNames.Add(Client1);
            dbNames.Add(Client2);
            ////////////////////////////Задание 3 

            //Добавить в BankClient виртуальный метод изменения данных, который будет разный для Consultant и Manager?
            //В методе добавить выбор какие данные изменять?? Какой-то счётчик? Если больше 0, то изменены.



            //////////////////////////////////////

            int choice;
            do
            {
                Console.WriteLine("Выберите, кто работает с данными:\n" +
                    "1 - Менеджер\n" +
                    "2 - Консультант\n" +
                    "0 - Выход");
                int change = Convert.ToInt32(Console.ReadLine());
                choice = change;
                if (change == 1)
                {
                    Console.WriteLine("Работает менеджер");


                    Manager Manager = new Manager();
                    int func1;
                    do
                    {
                        Console.WriteLine("1 - Изменить имя\n" +
                            "2 - Изменить фамилию\n" +
                            "3 - Изменить отчество\n" +
                            "4 - Изменить паспортные данные\n" +
                            "5 - Вывести информацию на экран\n" +
                            "0 - Выход в предыдущее меню");
                        int func = Convert.ToInt32(Console.ReadLine());
                        func1 = func;
                        switch (func)
                        {
                            case 1:
                                Console.WriteLine("Выберите номер клиента имя которого хотите изменить");

                                int numOfClient = Convert.ToInt32(Console.ReadLine());

                                Manager.SetFirsName(dbNames[numOfClient]);
                                
                                break;
                            case 2:
                                Manager.SetLastName(Client2);
                                break;
                            case 3:
                                Manager.SetPatronymic(Client2);
                                break;
                            case 4:
                                Manager.SetPassport(Client2);
                                break;
                            case 5:
                                
                                Console.WriteLine("Менеджер получает информацию о всех клиентах");

                                foreach (var a in dbNames)
                                {
                                    Manager.GetInfoConsultant(a);
                                }
                                Console.WriteLine("Менеджер получает информацию об одном клиенте");
                                Manager.GetInfoManager(Client2);

                                Console.WriteLine("Выберите номер клиента информацию о котором хотите вывести");
                                
                                int numOfClient1 = Convert.ToInt32(Console.ReadLine());
                                Manager.GetInfoManager(dbNames[numOfClient1]);
                                break;
                        }
                    } while (func1 != 0);

                    if (Manager.countFN > 0)
                    {
                        Console.WriteLine($"Менеждер изменил имя в {Manager.dateTimeModifyM}");
                    }
                    if (Manager.countLN > 0)
                    {
                        Console.WriteLine($"Менеждер изменил фамилию в {Manager.dateTimeModifyM}");
                    }
                    if (Manager.countP > 0)
                    {
                        Console.WriteLine($"Менеждер изменил отчество в {Manager.dateTimeModifyM}");
                    }
                    if (Manager.countPass > 0)
                    {
                        Console.WriteLine($"Менеждер изменил паспорт в {Manager.dateTimeModifyM}");
                    }
                }
                if (change == 2)
                {

                    Console.WriteLine("Работает консультант");

                    Consultant Consultant = new Consultant();
                    
                    Console.WriteLine("Консультант получает информацию о всех клиентах");
                    foreach (var a in dbNames) {
                        Consultant.GetInfoConsultant(a);
                    }

                    //Console.WriteLine("Консультант получает информацию");
                    //Consultant.GetInfoConsultant(Client1);
                    //Consultant.GetInfoConsultant(Client2);

                    Consultant.SetPhoneNumber(Client1);
                    if (Consultant.countConsul > 0)
                    {
                        Console.WriteLine($"Консультант изменил номер телефона в {Consultant.dateTimeModifyC}");
                    }

                }
            }while(choice != 0);

           

           
            
            //dateTimeModifyC = DateTime.Now;

            //else if (Manager.count1 > 0) {
            //    Console.WriteLine("Изменена фамилия");
            //}
            // 09082023 закрыл отладку
            /*
            Consultant.GetInfoConsultant(Client2);

            Consultant.SetPhoneNumber(Client2);
            
            Consultant.GetInfoConsultant(Client2);
            Console.WriteLine();
            
            Manager.SetFirsName(Client2);
            Manager.SetLastName(Client2);
            Manager.SetPatronymic(Client2);
            Manager.SetPhoneNumber(Client2);
            Manager.SetPassport(Client2);*/
                    
         


            //Client2.GetInfo();


            // выводим информацию о клиентах через консультанта
            //Consultant.ReadClientInfo(dbNames[1]);

            //Consultant.ReadClientInfo(dbNames[0]);

            //Consultant.Firstname_property = "dsfsd";


            //Consultant.ReadClientInfo(dbNames[0]);
            // 
            //Consultant.SetPhoneNumber(dbNames[0]);

            //Consultant.ReadClientInfo(dbNames[0]);

            //Console.WriteLine(Client2.Passport_property);
            // Console.WriteLine(Client2.Passport_property);

            //Console.WriteLine(Consultant.Passport_property);

            //Console.Write(Consultant.GetPassport());

            //Manager.setI("Смирнов");
            //Console.WriteLine(Manager.Lastname_property);


            //for (int i = 0; i < dbNames.Count; i++) {
            //   Consultant1.readClientInfo(dbNames[i]);
            //}

            /*
              if (String.IsNullOrEmpty(Client1.Passport_property));
              else Console.WriteLine(Client1.Passport_property);

              //Console.WriteLine(Client1.GetPassport());

              //Client1.SetPhoneNumber();

              Console.WriteLine(Client1.GetPhoneNumber());
              */

          
          

        }
    }



>>>>>>> origin
}