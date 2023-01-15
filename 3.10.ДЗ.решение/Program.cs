using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion

            Console.WriteLine("Правила игры. \nПрограмма загадывает случайное число." +
                "\nВ зависимости от сложности игры число может быть выбрано" +
                "из диапазона от 20 до 120 или введено с клавиатуры. \n" +
                "При выборе нормальной сложности игры, может быть задано разное кол-во игроков(от 2 до 5). \n" +
                "Так же может быть выбран режим игры с компьютером. \n" +
                "Игроки ходят по очереди (игра сообщает о ходе текущего игрока). \n" +
                "Игрок, ход которого указан вводит число, которое может принимать значения, \n" +
                "в зависимости от выбранного уровня сложности. Введенное число вычитается из загаданного \n" +
                "Выигрывает тот игрок, после чьего хода загаданное число обратилась в ноль.\n" +
                "Игра поздравляет победителя, предлагая сыграть реванш.\n");

            while (true)  //создаём бесконечный цикл игры 
            {
                Console.Write("Выберите уровень сложности: 1 - простой, 2 - нормальный, 3 - играть с компьютером. "); //вывод на экран выбора сложности игры
                int levelDiffculty = int.Parse(Console.ReadLine());  //считываем ввод пользователя для выбора уровня сложности игры

                switch (levelDiffculty)  //создаём переключатель для выбора уровня сложности игры
                {
                    #region Простой уровень сложности
                    case 1:     //1-ый уровень сложности. Число из диапазона [20;120], кол-во игроков 2
                        int userTry; //переменная для хранения значения хода игрока

                        Random rand = new Random(); //создаём генератор случайных чисел

                        int gameNumber = rand.Next(20, 120); // создаём переменную для загаданного числа и присваиваем значиение из диапазона 
                                                             // генератора случайный чисел 
                        Console.WriteLine("Введите имя первого игрока: ");  //сообщение о вводе имени первого игрока

                        string user1 = Console.ReadLine();  // считываем ввод и запоминаем имя игрока в переменную user1

                        Console.WriteLine("Введите имя второго игрока: ");  //сообщение о вводе имени второго игрока

                        string user2 = Console.ReadLine(); // считываем ввод и созраняем имя игрока в переменную user2

                        string currUser = user1; // создаём переменную для хранения текущего игрока и присваеваем ей значение user1

                        Console.WriteLine("Во время хода вводите число от 1 до 4: "); // выводим сообщение о вводе числа от 1 до 4

                        while (true)  //запускаем бесконечный цикл игры для 1 уровня сложности
                        {

                            Console.WriteLine($"Ход игрока {currUser}"); // выводим сообщение о ходе текущего игрока

                            userTry = Convert.ToInt32(Console.ReadLine()); // сохраняем ввод игрока в userTry

                            if (userTry >= 1 && userTry <= 4 && gameNumber >= userTry) // если пользовательский ввод лежит в пределах [1;4]
                            {                                                          // и загаданное число больше пользовательского ввода,
                                gameNumber = gameNumber - userTry;                     // то отними от загаданного пользовательский ввод
                                Console.WriteLine($"остаток = {gameNumber}");          // и сохрани новое значение загаданного и выведи его 
                                                                                       // на экран 
                                if (gameNumber == 0)                                   // если после этого загаданное число сравнялось 0
                                {
                                    Console.WriteLine($"Вы выиграли, {currUser}!");    // победил текущий игрок
                                    break;                                             // прерви цикл while и выйди в меню выбора сложности 

                                }
                                if (currUser == user2)                                 //если условие на 125 строке не выполнилось, проверяем
                                {                                                      //равен ли текущий игрок игроку user2 
                                    currUser = user1;                                  //если равено, то замени его на user1
                                }                   
                                else                                                   //иначе значению текущего игрока присвой user2
                                {
                                    currUser = user2;
                                }
                            }
                            else                                                        //если игрок ввёл неправильное число хода, 
                            {                                                           //или число хода больше, чем загаданное
                                Console.WriteLine("Неправильный ввод");                 //выведи "неправильный ввод" и попроси походить ещё раз
                            }

                        }
                       break;                                                           //прерываем игру первого уровня сложности и переходим
                    #endregion                                                          //к строке 686 предлагая сыграть ещё раз.
                    #region Второй уровень сложности
                    case 2:                                                             //2-ой уровень сложности. Пользователь вводит дипапазон
                                                                                        // для числа и хода. Кол-во игроков от 2 до 5. 
                        string user3;                                                   //объявление переменных для игроков с 3 по 5  
                        string user4;
                        string user5;
                        int numOfPlayers;                                               //переменная для выбора числа игроков

                        Random r = new Random();                                        //создаём генератор случайных чисел

                        while (true)                                                    //создаём цикл для ввода числа игроков 
                        {
                            Console.WriteLine("Введите число игроков:");                // вывод строки "введите число игроков"
                            numOfPlayers = Convert.ToInt32(Console.ReadLine());         // считываем ввод и сохраняем в переменную кол-во игроков
                            if (numOfPlayers >= 2 && numOfPlayers <= 5)                 // если ввод >=2 и <= 5, 
                            {            
                                break;                                                  //прерви цикл и продолжи программу
                            }
                            else {                                                      //иначе     
                                Console.WriteLine("Неправильный ввод, введите число от 2 до 5"); //выведи сообщение о неправильном вводе 
                            }                                                                   
                        }
                                             

                        Console.WriteLine("Введите диапазон для загаданного числа:");   //вывод сообщения для ввода диапазона 
                        gameNumber = r.Next(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); // сохраняем число из диапазона
                                                                                        //пользовательского ввода в gameNumber                                                              
                        Console.WriteLine("Введите минимальное значение числа для хода: "); //вывод сообщения для ввода мин. знач. числа для хода
                        int minUserTry = Convert.ToInt32(Console.ReadLine());               //создаём переменную мин. знач. числа для хода и сохраняем в неё
                                                                                            //пользовательский ввод
                        Console.WriteLine("Введите максимальное значение числа для хода: "); //вывод сообщения для ввода макс. знач. числа для хода
                        int maxUserTry = Convert.ToInt32(Console.ReadLine());                //создаём переменную макс. знач. числа для хода и сохраняем в неё
                                                                                             //пользовательский ввод

                        switch (numOfPlayers) {                                              //создаём переключатель по числу игроков
                            case 2:                                                          //случай, когда число игроков 2
                                Console.WriteLine("Введите имя первого игрока: ");           //вывод сообщения о вводе имени 1 игрока
                                user1 = Console.ReadLine();                                  //сохраняем пользовательский ввод в user1
                                currUser = user1;                                            //сохраняем user1 в текущего пользователя
                                Console.WriteLine("Введите имя второго игрока: ");           //вывод сообщения о вводе имени 2 игрока
                                user2 = Console.ReadLine(); user1 = Console.ReadLine();      //сохраняем пользовательский ввод в user1

                                while (true)                                                 //запускаем бесконечный цикл для игры с 2 игроками
                                {
                                    Console.WriteLine($"Ход игрока {currUser}");             //выводим сообщение о ходе текущего игрока
                                    userTry = Convert.ToInt32(Console.ReadLine());           //сохраняем пользовательский ввод, как ход игрока

                                    if (userTry >= minUserTry && userTry <= maxUserTry && gameNumber >= userTry)  //если ход игрока >= мин.числа для хода и
                                    {                                                        //<= макс. числа для хода и загаданное число >= хода игрока                                                                                                                    
                                        gameNumber = gameNumber - userTry;                   //отнимаем от загаданного числа ход игрока и сохраняем в заг. число
                                        Console.WriteLine($"остаток = {gameNumber}");        //выводим сообщение о результате

                                        if (gameNumber < minUserTry && gameNumber != 0)      //если заг. число меньше мин. хода игрока и загаданное число 
                                        {                                                    //не равно 0 (для реализации замены мин.числа для хода при загаданном числе меньше хода игрока)   
                                            if (currUser == user1)                           //если текущий пользователь user1 
                                            {
                                                currUser = user2;                            //замени его на user2
                                            }

                                            else                                             //иначе 
                                            {
                                                currUser = user1;                            //замени на user1
                                            }                                                   

                                            Console.WriteLine($"{currUser}, измените минимальное значение числа для хода. Введённое значение будет Ваши ходом! "); //вывод сообщения 
                                            minUserTry = Convert.ToInt32(Console.ReadLine());     //об изменении мин.значения для хода и сохранение в переменную пользовательского ввода
                                            while (minUserTry > gameNumber)     //пока мин.значение хода больше загаданного числа
                                            {
                                                Console.WriteLine($"Неправильный ввод. Введите число меньшее, либо равное {gameNumber}"); //выводим предупреждение о неправильном вводе
                                                minUserTry = Convert.ToInt32(Console.ReadLine()); //считываем и сохраняем в переменную мин. число для хода
                                            }

                                            userTry = minUserTry;  //сохраняем мин. число для хода в ход игрока
                                            gameNumber = gameNumber - userTry;  //вычитаем из загаданного числа ход игрока
                                            Console.WriteLine($"остаток = {gameNumber}");  //выводим загаданное число после хода игрока

                                            if (gameNumber == 0)                           //если после хода загаданное число = 0
                                            {
                                                Console.WriteLine($"Вы выиграли, {currUser}!"); //печатаем, что текущий игрок выиграл 
                                                break;                                          //прерываем цикл
                                            }
                                        }

                                        else if (gameNumber == 0)                   //если не пришлось изменять мин.число для хода игрока
                                        {                                           //то выигрывает, как обычно
                                            Console.WriteLine($"Вы выиграли, {currUser}!");
                                            break;
                                            Console.WriteLine("Давайте сыграем ещё!");
                                        }
                                        if (currUser == user1)                      //реализация смены текущего игрока от сих
                                        {
                                            currUser = user2;
                                        }

                                        else
                                        {
                                            currUser = user1;                       //до сих
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неправильный ввод");     //если неправильный ввод
                                    }
                                }

                                break;

                            case 3:  //реализация случая, при трёх игроках принципиально не отличается от с двумя игроками
                                Console.WriteLine("Введите имя первого игрока: ");
                                user1 = Console.ReadLine();
                                currUser = user1;
                                Console.WriteLine("Введите имя второго игрока: ");

                                user2 = Console.ReadLine();

                                Console.WriteLine("Введите имя третьего игрока: ");  //вывод сообщения о вводе имени третьего игрока

                                user3 = Console.ReadLine();                          //считываем имя 3 игрока и сохраняем в user3
                                while (true)
                                {

                                    Console.WriteLine($"Ход игрока {currUser}");

                                    userTry = Convert.ToInt32(Console.ReadLine());

                                    if (userTry >= minUserTry && userTry <= maxUserTry && gameNumber >= userTry)
                                    {
                                        gameNumber = gameNumber - userTry;
                                        Console.WriteLine($"остаток = {gameNumber}");

                                        if (gameNumber < minUserTry && gameNumber != 0)
                                        {
                                            if (currUser == user1)    //в переключение текущего игрока добавлен случай для 3 игрока
                                            {
                                                currUser = user2;
                                            }
                                            else if (currUser == user2)
                                            {
                                                currUser = user3;
                                            }
                                            else
                                            {
                                                currUser = user1;
                                            }

                                            Console.WriteLine($"{currUser}, измените минимальное значение числа для хода. Введённое значение будет Ваши ходом! ");
                                            minUserTry = Convert.ToInt32(Console.ReadLine());
                                            while (minUserTry > gameNumber)
                                            {
                                                Console.WriteLine($"Неправильный ввод. Введите число меньшее, либо равное {gameNumber}");
                                                minUserTry = Convert.ToInt32(Console.ReadLine());
                                            }

                                            userTry = minUserTry;
                                            gameNumber = gameNumber - userTry;
                                            Console.WriteLine($"остаток = {gameNumber}");

                                            if (gameNumber == 0)
                                            {
                                                Console.WriteLine($"Вы выиграли, {currUser}!");
                                                break;
                                            }
                                        }

                                        else if (gameNumber == 0)
                                        {
                                            Console.WriteLine($"Вы выиграли, {currUser}!");
                                            break;
                                            Console.WriteLine("Давайте сыграем ещё!");
                                        }
                                        if (currUser == user1)
                                        {
                                            currUser = user2;
                                        }
                                        else if (currUser == user2)
                                        {
                                            currUser = user3;
                                        }
                                        else
                                        {
                                            currUser = user1;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неправильный ввод");
                                    }                                   
                                }

                                break;
                            case 4:  // для 4 игроков добавлен ввод имени 4 игрока и переключение для четвертого игрока
                                Console.WriteLine("Введите имя первого игрока: ");
                                user1 = Console.ReadLine();
                                currUser = user1;
                                Console.WriteLine("Введите имя второго игрока: ");

                                user2 = Console.ReadLine();

                                Console.WriteLine("Введите имя третьего игрока: ");

                                user3 = Console.ReadLine();

                                Console.WriteLine("Введите имя четвёртого игрока: ");

                                user4 = Console.ReadLine();
                             while (true)
                                {

                                    Console.WriteLine($"Ход игрока {currUser}");

                                    userTry = Convert.ToInt32(Console.ReadLine());

                                    if (userTry >= minUserTry && userTry <= maxUserTry && gameNumber >= userTry)
                                    {
                                        gameNumber = gameNumber - userTry;
                                        Console.WriteLine($"остаток = {gameNumber}");

                                        if (gameNumber < minUserTry && gameNumber != 0)
                                        {
                                            if (currUser == user1)
                                            {
                                                currUser = user2;
                                            }
                                            else if (currUser == user2)
                                            {
                                                currUser = user3;
                                            }
                                            else if (currUser == user3)
                                            {
                                                currUser = user4;
                                            }
                                            else
                                            {
                                                currUser = user1;
                                            }

                                            Console.WriteLine($"{currUser}, измените минимальное значение числа для хода. Введённое значение будет Ваши ходом! ");
                                            minUserTry = Convert.ToInt32(Console.ReadLine());
                                            while (minUserTry > gameNumber)
                                            {
                                                Console.WriteLine($"Неправильный ввод. Введите число меньшее, либо равное {gameNumber}");
                                                minUserTry = Convert.ToInt32(Console.ReadLine());
                                            }

                                            userTry = minUserTry;
                                            gameNumber = gameNumber - userTry;
                                            Console.WriteLine($"остаток = {gameNumber}");

                                            if (gameNumber == 0)
                                            {
                                                Console.WriteLine($"Вы выиграли, {currUser}!");
                                                break;
                                            }
                                        }

                                        else if (gameNumber == 0)
                                        {
                                            Console.WriteLine($"Вы выиграли, {currUser}!");
                                            break;
                                            Console.WriteLine("Давайте сыграем ещё!");
                                        }
                                        if (currUser == user1)
                                        {
                                            currUser = user2;
                                        }
                                        else if (currUser == user2)
                                        {
                                            currUser = user3;
                                        }
                                        else if (currUser == user3)
                                        {
                                            currUser = user4;
                                        }
                                        else
                                        {
                                            currUser = user1;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неправильный ввод");
                                    }                                  
                                }

                                break;
                        
                        case 5: //для пяти игроков добавлен ввод имени 5-го игрока и переключение для пяти игроков
                        Console.WriteLine("Введите имя первого игрока: ");
                        user1 = Console.ReadLine();
                        currUser = user1;
                        Console.WriteLine("Введите имя второго игрока: ");

                        user2 = Console.ReadLine();

                        Console.WriteLine("Введите имя третьего игрока: ");

                        user3 = Console.ReadLine();

                        Console.WriteLine("Введите имя четвёртого игрока: ");

                        user4 = Console.ReadLine();

                        Console.WriteLine("Введите имя четвёртого игрока: ");

                        user5 = Console.ReadLine();
                        while (true)
                        {

                            Console.WriteLine($"Ход игрока {currUser}");

                            userTry = Convert.ToInt32(Console.ReadLine());

                            if (userTry >= minUserTry && userTry <= maxUserTry && gameNumber >= userTry)
                            {
                                gameNumber = gameNumber - userTry;
                                Console.WriteLine($"остаток = {gameNumber}");

                                if (gameNumber < minUserTry && gameNumber != 0)
                                {
                                    if (currUser == user1)
                                    {
                                        currUser = user2;
                                    }
                                    else if (currUser == user2)
                                    {
                                        currUser = user3;
                                    }
                                    else if (currUser == user3)
                                    {
                                        currUser = user4;
                                    }
                                    else if (currUser == user4)
                                    {
                                        currUser = user5;
                                    }
                                    else
                                    {
                                        currUser = user1;
                                    }

                                    Console.WriteLine($"{currUser}, измените минимальное значение числа для хода. Введённое значение будет Ваши ходом! ");
                                    minUserTry = Convert.ToInt32(Console.ReadLine());
                                    while (minUserTry > gameNumber)
                                    {
                                        Console.WriteLine($"Неправильный ввод. Введите число меньшее, либо равное {gameNumber}");
                                        minUserTry = Convert.ToInt32(Console.ReadLine());
                                    }

                                    userTry = minUserTry;
                                    gameNumber = gameNumber - userTry;
                                    Console.WriteLine($"остаток = {gameNumber}");

                                    if (gameNumber == 0)
                                    {
                                        Console.WriteLine($"Вы выиграли, {currUser}!");
                                        break;
                                    }
                                }

                                else if (gameNumber == 0)
                                {
                                    Console.WriteLine($"Вы выиграли, {currUser}!");
                                    break;
                                    Console.WriteLine("Давайте сыграем ещё!");
                                }
                                if (currUser == user1)
                                {
                                    currUser = user2;
                                }
                                else if (currUser == user2)
                                {
                                    currUser = user3;
                                }
                                else if (currUser == user3)
                                {
                                    currUser = user4;
                                }
                                else if (currUser == user4)
                                {
                                    currUser = user5;
                                }
                                else
                                {
                                    currUser = user1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Неправильный ввод");
                            }
                        }

                        break;
                }
      
                        Console.WriteLine("Давайте сыграем ещё!");
                        break;
                        Console.ReadKey();
                    #endregion
                    #region Третий уровень сложности
                    case 3: // 3-ий уровень. Игра с компьютером
                        
                        Console.WriteLine("Играть с компьютером"); // выводим сообщение об игре с компьютером

                        Random ran = new Random();                 //создаём генератор случайных чисел для загадывания числа
                        Random ct = new Random();                  //создаём генератор случайных чисел для хода компьютера
                       // Console.WriteLine("Введите диапазон для загаданного значения: ");

                        
                        //gameNumber = ran.Next(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); //вводим диапазон для загаданного числа и сохраняем в gameNumber
                     int minValue;
                     int maxValue;
                        while (true) { 
                     
                            Console.WriteLine("Введите минимальное значение диапазона");                     
                            minValue = Convert.ToInt32(Console.ReadLine());
                            if (minValue >= 0)
                            {
                                break;
                            }
                            else {
                                Console.WriteLine("Неправильный ввод");
                            }
                        }
                        while (true) { 
                     
                            Console.WriteLine("Введите максимальное значение диапазона");                
                            maxValue = Convert.ToInt32(Console.ReadLine());
                            if (maxValue > minValue)
                            {
                                break;
                            }
                            else {
                                Console.WriteLine("Неправильный ввод");
                            }
                        }
                        gameNumber = ran.Next(minValue, maxValue);

                        while (true)
                        {
                            Console.WriteLine("Введите минимальное значение числа для хода: "); //вывод сообщения о вводе мин числа для хода
                            minUserTry = Convert.ToInt32(Console.ReadLine());                   //считываем и сохраняем мин число для хода
                            if (minUserTry >= 0)
                            {
                                break;
                            }
                            else {
                                Console.WriteLine("Неправильный ввод");
                            }
                        }
                        while (true)
                        {
                            Console.WriteLine("Введите максимальное значение числа для хода: ");  //вывод сообщения о вводе макс числа для хода
                            maxUserTry = Convert.ToInt32(Console.ReadLine());                     //считываем и сохраняем макс число для хода
                            if (maxUserTry <= maxValue)
                            {
                                break;
                            }
                            else {
                                Console.WriteLine("Неправильный ввод");
                            }
                        }
                        Console.WriteLine("Введите имя игрока: ");                            //вывод сообщения о вводе имени игрока

                         user1 = Console.ReadLine();                                          //считали ввод и сохранили значение в user1

                         user2 = "computer";                                                  //присвоили переменной user2 значение computer

                         currUser = user1;                                                    //выбрали текущим игроком user1

                        while (true)                                                          //запускаем бесконечный цикл для ходов игроков
                        {
                            int compTurn;                                                     //создали переменную для хода компьютера
                            Console.WriteLine($"Ход игрока {user1}");                         //вывод сообщения о ходе игрока

                            userTry = Convert.ToInt32(Console.ReadLine());                    //сохраняем ввод для хода игрока(человека)

                            if (userTry >= minUserTry && userTry <= maxUserTry && gameNumber >= userTry) //если ход игрока >= мин. ввода 
                            {           //и <= макс. ввода и загаданное число >= хода игрока
                                gameNumber = gameNumber - userTry;  //то измени загаданное число на ход игрока
                                Console.WriteLine($"остаток = {gameNumber}"); //выведи результат

                                if (gameNumber == 0)    //если загаданное число стало 0 
                                {
                                    Console.WriteLine($"Вы выиграли, {currUser}!"); //печатаем, что выиграл текущий игрок
                                    break;                                          //прерываем цикл
                                    // Console.WriteLine("Давайте сыграем ещё!");
                                }

                                if (gameNumber > maxUserTry)  //если загаданное число больше макс. хода 
                                {
                                    compTurn = ct.Next(minUserTry, maxUserTry); //то ход компьютера будет случайным числом в диапазоне [мин.ход; макс.ход]
                                    Console.WriteLine($"Компьютер походил: {compTurn}"); //печатаем результат хода компьютера
                                    gameNumber = gameNumber - compTurn;    //изменяем загаданное число на ход компьютера
                                    Console.WriteLine($"остаток = {gameNumber}");  //печатаем текущее значение загаданного числа
                                }
                                else if (gameNumber >= minUserTry && gameNumber <= maxUserTry) //иначе, если загаданное число >= мин. хода и <= макс. хода
                                {
                                    compTurn = gameNumber;  // сохрани значение загаданного числа в ход компа 
                                    gameNumber = gameNumber - compTurn; //вычти из загаданного числа ход компа
                                    Console.WriteLine($"Компьютер походил: {compTurn}"); //печатаем результат 0
                                    Console.WriteLine("Выиграл компьютер!"); //печатаем комп выиграл
                                    break;
                                }
                                else if (gameNumber < minUserTry) //иначе если загаданное число меньше мин хода
                                
                                {
                                    if (currUser == user1)  //меняем текущего игрока по сути для хода компа
                                    {
                                        currUser = user2;
                                    }
                                    
                                    Console.WriteLine($"{currUser} изменил минимальное значение числа для хода "); //печатаем сообщение об изменении мин хода
                                    compTurn = gameNumber; // см. строки 604-608
                                    gameNumber = gameNumber - compTurn;
                                    Console.WriteLine($"остаток = {gameNumber}");
                                    Console.WriteLine("Выиграл компьютер!");
                                    break;
                                }
                            }
                            else if (gameNumber < minUserTry) //иначе, если загаданное число меньше мин. хода, по сути для хода игрока
                            {
                                Console.WriteLine($"{currUser}, измените минимальное значение числа для хода. Введённое значение будет Ваши ходом! "); //печатаем, что тек. игрок изменил мин. ход
                                minUserTry = Convert.ToInt32(Console.ReadLine()); //считываем мин. ход
                                while (minUserTry > gameNumber)  //запускаем цикл для правильного значения хода, пока мин ход больше загаданного числа
                                {
                                    Console.WriteLine($"Неправильный ввод. Введите число меньшее, либо равное {gameNumber}"); //печатаем, что неправильный ввод
                                    minUserTry = Convert.ToInt32(Console.ReadLine()); //считываем новый ввод
                                }
                                userTry = minUserTry;   //присваиваем изменённый мин ход ходу игрока
                                gameNumber = gameNumber - userTry;  //вычисляем загаданное число
                                Console.WriteLine($"остаток = {gameNumber}"); //выводим результат
                            }
  
                            else
                            {
                                Console.WriteLine("Неправильный ввод"); //иначе неправильный ввод хода игрока
                            }
                        }

                        break; //завершаем случай игры с компом

                        }
                #endregion
                Console.WriteLine("Давайте сыграем ещё!");  // предлагаем сыграть реванш
                   

                }
                
            }
        }
    }

