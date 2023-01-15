using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace Homework_07
{
    class Program
    {
        static void Main(string[] args)
        {

            if (File.Exists("guide.csv") == true) { }
            else
            {
                var myFile = File.Create("guide.csv");
                myFile.Close(); //что бы можно было считывать из файла
            }

            string path = @"guide.csv";
            Repository rep = new Repository(path);  // создадим структуру справочник

            int command;
            do
            {
                printMenu();    // печать меню в консоль
                command = Convert.ToInt32(Console.ReadLine());  // считываем выбранный пункт меню
                switch (command)
                {
                    case 1:
                        rep.PrintDbToConsole(); // вывод справочника в консоль
                        break;
                    case 2:
                        rep.Printid(Convert.ToInt32(Console.ReadLine()));   // вывод информации о сотруднике по ID
                        break;
                    case 3:
                        rep.AddIn(new Worker(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToDateTime(Console.ReadLine()), Console.ReadLine(), DateTime.Now));                        
                        break;
                    case 4:
                        rep.Del("guide.csv");
                        break;
                    case 5:
                        Console.WriteLine("Введите дату от");
                        DateTime dateFrom = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Введите дату до");
                        DateTime dateTo = Convert.ToDateTime(Console.ReadLine());
                        rep.GetWorkersBetweenTwoDates(dateFrom, dateTo);                       
                        break;
                    case 6:
                        rep.Sort();
                        break;
                    case 0:
                        Console.WriteLine("Пока!");
                        break;
                }
            }
            while (command != 0);
        }


        /// <summary>
        /// Печать меню задания 
        /// </summary>
        /// 
        public static void printMenu()
        {
            Console.WriteLine("Что хотите сделать?");
            Console.WriteLine("1 - вывести справочник на экран.");
            Console.WriteLine("2 - вывести запись из справочника по идентификатору");
            Console.WriteLine("3 - внести запись в справочник");
            Console.WriteLine("4 - удалить запись из справочника");
            Console.WriteLine("5 - вывести записи из выбранного диапазона дат");
            Console.WriteLine("6 - сортировка");
            Console.WriteLine("0 - выход");
        }       

    }
}
 
