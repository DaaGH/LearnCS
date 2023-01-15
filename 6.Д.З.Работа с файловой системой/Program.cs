using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Homework_06
{
    class Program
    {
        static void Main(string[] args)
        {
#region Условие домашнего задания 1
            /// 
            ///
            /// Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
            /// своих навыков. 
            /// 
            /// Немного подумав они вспомнили, что не так давно на занятиях по математике
            /// они проходили тему "свойства делимости целых чисел". На этом занятии преподаватель показывал
            /// пример с использованием фактов делимости. 
            /// Пример заключался в следующем: 
            /// Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
            /// так, что если одно число делится на другое, то эти числа попадают в разные руппы. 
            /// В результате этого разбиения получилось M групп, для N = 50, M = 6
            /// 
            /// N = 50
            /// Группы получились такими: 
            /// 
            /// Группа 1: 1
            /// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            /// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
            /// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
            /// Группа 5: 16 24 36 40
            /// Группа 6: 32 48
            /// 
            /// M = 6
            /// 
            /// ===========
            /// 
            /// N = 10
            /// Группы получились такими: 
            /// 
            /// Группа 1: 1
            /// Группа 2: 2 7 9
            /// Группа 3: 3 4 10
            /// Группа 4: 5 6 8
            /// 
            /// M = 4
            /// 
            /// Участники хакатона решили эту задачу, добавив в неё следующие возможности:
            /// 1. Программа считыват из файла (путь к которому можно указать) некоторое N, 
            ///    для которого нужно подсчитать количество групп
            ///    Программа работает с числами N не превосходящими 1 000 000 000
            ///   
            /// 2. В ней есть два режима работы:
            ///   2.1. Первый - в консоли показывается только количество групп, т е значение M
            ///   2.2. Второй - программа получает заполненные группы и записывает их в файл используя один из
            ///                 вариантов работы с файлами
            ///            
            /// 3. После выполения пунктов 2.1 или 2.2 в консоли отображается время, за которое был выдан результат 
            ///    в секундах и миллисекундах
            /// 
            /// 4. После выполнения пунта 2.2 программа предлагает заархивировать данные и если пользователь соглашается -
            /// делает это.
            /// 
            /// Попробуйте составить конкуренцию начинающим программистам и решить предложенную задачу
            /// (добавление новых возможностей не возбраняется)
            ///
            /// * При выполнении текущего задания, необходимо документировать код 
            ///   Как пометками, так и xml документацией
            ///   В обязательном порядке создать несколько собственных методов
            #endregion
#region Меню выбора задания
            while (true)
            {
                Console.WriteLine("Выберите номер задачи: \n" +
                    "1 - Задача 1 свойства делимости целых чисел\n" +
                    "2 - Задача 2 справочник \"Сотрудники\" \n" +
                    "3 - Выход");
                int task = Convert.ToInt16(Console.ReadLine());
#endregion
        #region Задание 1
                if (task == 1)
                {
                    
                    ulong N;
                    int M = 0;
                    DateTime date = new DateTime();
                    N = readN(); //Создаём файл в который запишем некоторое N.Это N будет количество элементов в массиве чисел. Считаем это N.

                    ulong[] arr = new ulong[N]; //Далее запускаем цикл по заполнению массива числами от 1 до N c шагом 1.

                    ulong a = 1;
                    arr = pullArr(arr, a);
                   
                    //Создадим цикл в котором будем брать значение первого индекса и делить последовательно с каждым индексом
                    ulong j = 0;
                    string note = null;
                    date = DateTime.Now;

                    groupping(arr, j, note); // группируем числа
                   
                    countId1(M); // считаем группы
      
                    //Считаем за сколько выполнилась операция
                    TimeSpan timeSpan = DateTime.Now.Subtract(date);
                    Console.WriteLine($"Операция выполнена за {timeSpan.TotalMilliseconds} мс");
                    Console.WriteLine($"В секундах {timeSpan.TotalSeconds} с");

                    archive(); //Архивировать?
#endregion
#region Условие домашнего задания 2
                    // Задание 2---------------------------------------------------------------------------------------------------------
                    //            Что нужно сделать
                    //Создайте справочник «Сотрудники».

                    //Разработайте для предполагаемой компании программу, которая будет добавлять записи новых сотрудников в файл. Файл должен содержать следующие данные:

                    //ID
                    //Дату и время добавления записи
                    //Ф.И.О.
                    //Возраст
                    //Рост
                    //Дату рождения
                    //Место рождения
                    //Для этого необходим ввод данных с клавиатуры.После ввода данных:

                    //            если файла не существует, его необходимо создать;
                    //            если файл существует, то необходимо записать данные сотрудника в конец файла. 
                    //При запуске программы должен быть выбор:

                    //введём 1 — вывести данные на экран;
                    //введём 2 — заполнить данные и добавить новую запись в конец файла.


                    //Файл должен иметь следующую структуру:

                    //1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва
                    //2#15.12.2021 03:12#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск
                    //…


                    //Советы и рекомендации
                    //Обратите внимание, что в строке есть символ # — разделитель в строке. При чтении файла необходимо убрать символ #. Разбить строку на массив элементов поможет разделение строк с помощью метода String.Split.
                    //Разбейте программу на методы(чтение, запись).
                    //Новую запись внесите в конец файла.
                    //Проверьте, создан файл или нет.
                }
                #endregion

        #region Задание 2

                else if (task == 2)
                {
                    int command;

                    printMenu();    //Выводим что необходимо сделать (меню)
                    command = Convert.ToInt32(Console.ReadLine());

                    if (command == 1)
                    {

                        dataOut();      // вывод базы данных на экран

                    }
                    else if (command == 2)
                    {
                        int id = 0;

                        if (File.Exists("guide.csv") == true)  // если база существует
                        {

                            id = countId(id);   // считаем порядковый номер для добавления следующей записи

                            dataIn(id);

                        }

                        else  // если это первый ввод, то порядковый номер равен 1
                        {

                            int i = 1;

                            dataIn(i);

                        }
                    }
                }
                else {
                    Console.WriteLine("Adios!");
                    break;
                }
            }
        }
        #endregion

#region Функции задания 1
        /// <summary>
        ///  Архивирование файла с группами чисел   
        /// </summary>
        public static void archive() {
            string source = "db.csv";
            string compressed = "db.zip";

            char key = 'д';
            Console.Write("Заархивировать н/д? \n");
            key = Console.ReadKey(true).KeyChar;
            if (char.ToLower(key) == 'д')
            {
                using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
                {
                    using (FileStream ts = File.Create(compressed))   // поток для записи сжатого файла
                    {
                        // поток архивации
                        using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                        {
                            ss.CopyTo(cs); // копируем байты из одного потока в другой
                            Console.WriteLine("Сжатие файла {0} завершено. Было: {1}  стало: {2}.",
                                              source,
                                              ss.Length,
                                              ts.Length);
                        }
                    }
                }
            }
            Console.WriteLine($"Выход\n");          
        }
        /// <summary>
        /// Заполнение массива числами от 1 до N
        /// </summary>
        /// <param name="ARR"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static ulong[] pullArr(ulong[] ARR, ulong A) {
            for (ulong q = 0; q < Convert.ToUInt64(ARR.Length); q++)
            {

                ARR[q] = A;
                A++;
            }
            return ARR;
        }
        /// <summary>
        /// Условие группирования чисел и запись в файл 
        /// </summary>
        /// <param name="ARR"></param>
        /// <param name="J"></param>
        /// <param name="NOTE"></param>
        public static void groupping(ulong[] ARR , ulong J, string NOTE) {
            using (StreamWriter sw = new StreamWriter("db.csv", true, Encoding.Unicode))
            {
                for (ulong i = 1; i < Convert.ToUInt64(ARR.Length); i++)
                {
                    double z;
                    z = ARR[i] % ARR[J];

                    if (z == 0 && J == 0)

                    {
                        NOTE += $"{ARR[J]} ";
                        NOTE += $"\n{ARR[i]} ";

                        J = i;
                    }
                    else if (z == 0)
                    {
                        NOTE += $"\n{ARR[i]} ";
                        J = i;
                    }
                    else
                    {
                        NOTE += $"{ARR[i]} ";
                    }
                }
                sw.WriteLine(NOTE);
            }
        }
        /// <summary>
        /// Функция считывания N из файла N.csv
        /// </summary>
        /// <returns></returns>
        public static ulong readN (){
            ulong Nn;
            using (StreamReader sr = new StreamReader("N.csv", Encoding.Unicode))
            {
               
                string line;
                line = sr.ReadLine();
                Nn = Convert.ToUInt64(line);               
            }
            if (Nn > 1_000_000_000)
            {
                Console.WriteLine("Неправильное число N!");
                Environment.Exit(0);
            }
            return Nn;
        }
        /// <summary>
        /// Функиця подсчёта количества групп
        /// </summary>
        /// <param name="yd"></param>
        public static void countId1(int yd)
        {
            using (StreamReader sr = new StreamReader("db.csv", Encoding.Unicode))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    yd++;                  
                }
            }
        
            Console.WriteLine($"Количество групп - {yd}");
        }
        #endregion

#region Функции задания 2
        /// <summary>
        /// Печать меню задания 2
        /// </summary>
        public static void printMenu()
    {
        Console.WriteLine("Что хотите сделать?");
        Console.WriteLine("1 - вывести данные на экран.");
        Console.WriteLine("2 - заполнить данные и добавить новую запись в конец файла.");
    }
    /// <summary>
    /// Функция вывода записей справочника в консоль
    /// </summary>
    public static void dataOut()
    {
        using (StreamReader sr = new StreamReader("guide.csv", Encoding.Unicode))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] arr = line.Split('#');
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                    if (i == (arr.Length - 1))
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }

    /// <summary>
    /// Подсчёт ID 
    /// </summary>
    /// <param name="yd"></param>
    /// <returns></returns>    
    public static int countId(int yd)
    {
        using (StreamReader sr = new StreamReader("guide.csv", Encoding.Unicode))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                yd++;                
            }
        }
        return ++yd;
    }
    /// <summary>
    /// Функция добавления записей в справочник
    /// </summary>
    /// <param name="ident"></param>
    public static void dataIn(int ident)
    {
        using (StreamWriter sw = new StreamWriter("guide.csv", true, Encoding.Unicode))
        {
            char key = 'д';

            do
            {

                string note = string.Empty;
                note += $"{ident} #";

                string now = DateTime.Now.ToString();
                Console.WriteLine($"Дата и время добавления записи {now}");
                note += $"{now}#";

                Console.Write("Введите ФИО: ");
                note += $"{Console.ReadLine()}#";

                Console.Write("Введите возраст: ");
                note += $"{Console.ReadLine()}#";


                Console.Write("Введите рост: ");
                note += $"{Console.ReadLine()}#";


                Console.Write("Введите дату рождения: ");
                note += $"{Console.ReadLine()}#";

                Console.Write("Введите место рождения: ");
                note += $"{Console.ReadLine()}#";


                sw.WriteLine(note); //записать содержимое note в поток sw

                Console.Write("Продожить н/д\n"); key = Console.ReadKey(true).KeyChar;

                ident++;

            } while (char.ToLower(key) == 'д');
        }
    }
        
    }
}


#endregion
