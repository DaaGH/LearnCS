using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_08
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Создать прототип информационной системы, в которой есть возможност работать со структурой организации
            /// В структуре присутствуют департаменты и сотрудники
            /// Каждый департамент может содержать не более 1_000_000 сотрудников.
            /// У каждого департамента есть поля: наименование, дата создания,
            /// количество сотрудников числящихся в нём 
            /// (можно добавить свои пожелания)
            /// 
            /// У каждого сотрудника есть поля: Фамилия, Имя, Возраст, департамент в котором он числится, 
            /// уникальный номер, размер оплаты труда, количество закрепленным за ним.
            ///
            /// В данной информаиционной системе должна быть возможность 
            /// - импорта и экспорта всей информации в xml и json
            /// Добавление, удаление, редактирование сотрудников и департаментов
            /// 
            /// * Реализовать возможность упорядочивания сотрудников в рамках одно департамента 
            /// по нескольким полям, например возрасту и оплате труда
            /// 
            ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
            ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
            ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
            ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
            ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
            ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
            ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
            ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
            ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
            ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
            /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
            /// 
            /// 
            /// Упорядочивание по одному полю возраст
            /// 
            ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
            ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
            /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
            ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
            ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
            ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
            ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
            ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
            ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
            ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
            ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
            /// 
            ///
            /// Упорядочивание по полям возраст и оплате труда
            /// 
            ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
            /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
            ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
            ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
            ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
            ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
            ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
            ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
            ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
            ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
            ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
            /// 
            /// 
            /// Упорядочивание по полям возраст и оплате труда в рамках одного департамента
            /// 
            ///  №     Имя       Фамилия     Возраст     Департамент     Оплата труда    Количество проектов
            ///  9   Имя_9     Фамилия_9          21         Отдел_1            30000                      3 
            ///  6   Имя_6     Фамилия_6          22         Отдел_1            10000                      3 
            ///  3   Имя_3     Фамилия_3          22         Отдел_1            20000                      3 
            ///  1   Имя_1     Фамилия_1          23         Отдел_1            10000                      3 
            ///  7   Имя_7     Фамилия_7          23         Отдел_1            20000                      3 
            ///  8   Имя_8     Фамилия_8          23         Отдел_1            30000                      3 
            ///  4   Имя_4     Фамилия_4          24         Отдел_1            10000                      3 
            /// 10  Имя_10    Фамилия_10          21         Отдел_2            10000                      3 
            ///  2   Имя_2     Фамилия_2          21         Отдел_2            20000                      3 
            ///  5   Имя_5     Фамилия_5          22         Отдел_2            20000                      3 
            /// 
            while (true) {
                PrintMenu();    // печать меню выбора задания
                int command = Convert.ToInt32(Console.ReadLine());  //  пользовательский ввод сохраняем в переменную

                switch (command)    // в зависимости от ввода выбирается задание
                {
                    case 1: //  Задание 1

                        List<int> list = new List<int>();   // создаём новую коллекцию list

                        Random random = new Random();   // создаём рандомайзер

                        addNums(list, random);   // заполняем случайными значениями list

                        printList(list);    // выводим на экран значения из list

                        delNums(list);     // удаляем все из диапазона от 25 до 50 

                        printList(list);    // выводим list после удаления

                        Console.WriteLine();

                        break;

                    case 2: //  Задание 2

                        Dictionary<string, string> guide = new Dictionary<string, string>();    //  инициаизируем словарь

                        addRecord(guide);   //  добавления ФИО и телефона в словарь

                        nameOut(guide);     //  вывод ФИО по номеру из словаря

                        break;

                    case 3: //  Задание 3

                        HashSet<int> set1 = new HashSet<int>(); //  инициализируем множество

                       // char key = 'д';
                        char key;   // создаём переменную для управления пользовательским вводом
                        do  //  цикл пользовательского ввода, если key == д, то ввод продолжается
                        {
                            Console.WriteLine("Введите число для сохранения");  
                            int num = Convert.ToInt32(Console.ReadLine());  //  сохраняем пользовательский ввод 
                            bool cont = set1.Contains(num);     //  инициализируем Булеву переменную в которой сохраняем результат содержится ли введённое число в множестве

                            if (cont)   // если да, выводим соответствующее сообщение
                            {
                                Console.WriteLine("Это число уже содержится");
                            }
                            else    //  иначе добавляем число в множество
                            {
                                set1.Add(num);
                                Console.WriteLine("Число успешно сохранено");
                            }
                            Console.WriteLine("Продолжить ввод?");
                            Console.WriteLine("Продожить н/д"); key = Console.ReadKey(true).KeyChar;    //  считываем пользовательский ввод 
                        } while (char.ToLower(key) == 'д'); // цикл работает пока key == д 

                        Console.Write("Введнные Вами числа: ");

                        foreach (var n in set1) {
                            Console.Write($"{n} ");                            
                        }
                        Console.WriteLine();

                        break;

                    case 4: //  Задание 4
                        Console.WriteLine("Введите имя");
                        XElement PERSON = new XElement("Person");   //  создание узла Person
                        XAttribute name = new XAttribute("name", Console.ReadLine());   //  создание атрибута и передача ему значения из пользовательского ввода
                        XElement ADDRESS = new XElement("Address"); //  создание узла Address
                        Console.WriteLine("Введите улицу");
                        XElement STREET = new XElement("Street", Console.ReadLine());   //  создание узла Street и передача ему значения из пользовательского ввода
                        Console.WriteLine("Введите номер дома");
                        XElement HOUSENUMBER = new XElement("HouseNumber", Console.ReadLine()); //  создание узла HouseNumber и передача ему значения из пользовательского ввода
                        Console.WriteLine("Введите номер улицы");
                        XElement FLATNUMBER = new XElement("FlatNumber", Console.ReadLine());   //  создание узла FlatNumber и передача ему значения из пользовательского ввода

                        XElement PHONES = new XElement("Phones");   //  создание узла Phones
                        Console.WriteLine("Введите мобильный телефон");
                        XElement MOBILEPHONE = new XElement("MobilePhone", Console.ReadLine()); //  создание узла MobilePhone и передача ему значения из пользовательского ввода
                        Console.WriteLine("Введите домашний телефон");
                        XElement FLATPHONE = new XElement("FlatPhone", Console.ReadLine()); //  создание узла FlatPhone и передача ему значения из пользовательского ввода

                        PERSON.Add(name);   //  добавляем атрибут name к узлу Person
                        PERSON.Add(ADDRESS);    //  добавляем узел Address к узлу Person
                        ADDRESS.Add(STREET);    //  добавляем узел Street к узлу Address
                        ADDRESS.Add(HOUSENUMBER);   //  добавляем узел HouseNumber к узлу Address
                        ADDRESS.Add(FLATNUMBER);    //   добавляем узел FlatNumber к узлу Address


                        PERSON.Add(PHONES); //   добавляем узел Phones к узлу Person
                        PHONES.Add(MOBILEPHONE);    //   добавляем узел MobilePhone к узлу Phones
                        PHONES.Add(FLATPHONE);  //  добавляем узел FlatPhone к узлу Phones


                        PERSON.Save("_PERSON.xml"); //  сохраняем получившийся xml 
                        break;

                    case 0:     //  выход из программы
                        return;
                }
            }
        }




        public static void PrintMenu() {    //  функция печати меню
            Console.WriteLine("#############################################");
            Console.WriteLine("Выберите задание: \n" +
                "1 - работа с листом \n" +
                "2 - телефонная книга \n" +
                "3 - проверка повторов \n" +
                "4 - записная книжка \n" +
                "0 - выход");
            Console.WriteLine("#############################################");
        }


        #region Функции задания 1
        public static void addNums(List<int> list, Random random) {

            for (int i = 0; i < 100; i++)   // заполняем list случайными числами от 0 до 100
            {
                list.Add(random.Next(100));

            }

            Console.WriteLine("После заполнения");

        }

        public static void printList(List<int> list) {      // вывод значений из list

            for (int i = 0; i < list.Count; i++) {

                Console.Write($"{list[i]} ");

            }

        }

        public static void delNums(List<int> list) {    // уаление чисел из list
            int countDel = 0;   // счётчик удалённых
            int count = 0;  // счётчик оставшихся
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 && list[i] < 50)   // удаляем все числа от 25 до 50 
                {
                    list.RemoveAt(i);
                    i--;     // при удалении элемента из list уменьшается его длина поэтому уменьшаем i
                    countDel++;
                }
                else {
                    count++;
                }

            }

            Console.WriteLine("\nПосле удаления");
            Console.WriteLine($"Удалённых {countDel}");
            Console.WriteLine($"Осталось {count}");


        }
        #endregion

        #region Функции задания 2

        public static Dictionary<string, string> addRecord (Dictionary<string, string> guide){  //  функция добавления ФИО и телефона в словарь

            int userInput;  // переменная для хранения пользовательского ввода в меню

            while (true)       //   бесконечный цикл для добавления записей в словарь
            {
                Console.WriteLine("1 - Добавить запись в справочник \n" +
               "0 - прекратить ввод");
                userInput = Convert.ToInt32(Console.ReadLine());    // считываем пользовательский ввод
                if (userInput == 0) // если 0 ввод завершён
                {
                    Console.WriteLine("Ввод завершён");
                    break;          // выходим из цикла
                }
                else
                {      // иначе добавляем пользователя
                    Console.WriteLine("Введите ФИО и телефон");

                    guide.Add(Console.ReadLine(), Console.ReadLine());  // считываем ввод ФИО и телефона и добавляем в словарь
                }
            }

            return guide;
        }

        public static void nameOut (Dictionary<string, string> guide) { // функция вывода ФИО по телефону

            Console.WriteLine("Введите номер телефона для поиска владельца");

            string tel = Console.ReadLine();    // считываем номер телефона для поиска владельца

            foreach (KeyValuePair<string, string> e in guide)   //  проходим по всем элементам словаря 
            {
                if (e.Value == tel) // если текущий элемент словаря равен введённому телефону
                {

                    if (guide.TryGetValue(e.Key, out tel))  // и, если введённому значению соответсвует ключ в словаре
                    {
                        Console.WriteLine($"Телефон {e.Value} принадлежит {e.Key}");    //  выводим в консоль соответствующую пару ключ-значение(т.е. ФИО - телефон)
                    }
                }
            }
        }

        #endregion
    }
}
