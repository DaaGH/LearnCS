using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 Месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по Месяцам
            // Количество Месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по Месяцам, с худшей прибылью, 
            // если есть несколько Месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в Месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
            #endregion +
            #region Задание 2
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника Паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //

            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля

            #endregion
            #region Задание 3
            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
            #endregion
            int numbTask;
            Console.WriteLine("Введите номер задачи: ");
            Console.WriteLine("1 - задача 3.1;");
            Console.WriteLine("2 - задача 3.2;");
            Console.WriteLine("3 - задача 3.3");
            Console.WriteLine();
            numbTask = Convert.ToInt32(Console.ReadLine());
            switch (numbTask)
            {
                case 1:
                    #region Решение задачи 1
                    int[,] account = new int[12, 4];  //инициализирем двумерный массив, где 12 строк и 4 столбца
                    Random random = new Random();     //добавляем генератор случайных чисел
                    int month = 1;                    //вводим переменную для вывода Месяца со значением 1
                    int monthWithProfit = 0;          //вводим переменную для подсчёта Месяцев с положительной прибылью
                    int monthMinProfit = 0;           //вводим переменную для подсчёта Месяцев с прибылью меньше 20_000
                    int monthAndProfit = 0;           //вводим переменную, которая будет использоваться в формировании массивов с Месяцами и Прибылью, для вывода худших Месяцев

                    //           var keysacount = new int[12];
                    //           var xacount = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    var header = new string[] { "Месяц", "Доход, тыс. руб.", "Расход, тыс. руб.", "Прибыль, тыс. руб." }; //создаём строковый массив для шапки 
                    for (int indexHeader = 0; indexHeader < header.Length; indexHeader++)  //выводим значения массива на экран с нужным форматированием
                    {
                        if (header[indexHeader] == "Месяц")                                //если значение в массиве равно "Месяц"
                        {
                            Console.Write($"{header[indexHeader]} ");                      //то выводим, как есть
                        }
                        else                                                               //иначе
                        {
                            Console.Write($"{header[indexHeader],20}");                    //для остальных значений используем форматирование в 20 символов
                        }
                    }
                    Console.WriteLine();

                    for (int stringAccount = 0; stringAccount < account.GetLength(0); stringAccount++)
                    {    //цикл для создания строк в массиве
                         // Console.Write($"{stringAccount,5}");
                        for (int columnAccount = 0; columnAccount < account.GetLength(1); columnAccount++)
                        { //цикл для создания столбцов в массиве
                          //     Console.Write($"{columnAccount,5}");
                            if (columnAccount == 0)                                 //если колонка первая (индекс = 0)
                            {
                                account[stringAccount, columnAccount] = month++;    //то пишем в неё номер Месяца и увеличиваем значение Месяца на 1
                                Console.Write($"{account[stringAccount, columnAccount],5}");  //выводим на экран номер Месяца в текущую строку первой! колонки с форматированием в 5 символов

                            }
                            else                                                                        //иначе 
                            {
                                if (columnAccount != 3)
                                {                                               //если колонка не четвёртая (не Прибыль)
                                    account[stringAccount, columnAccount] = random.Next(-10, 13) * 10000;       //пишем в текущую колонку текущей строки случайное число из диапазона от 0 до 200 000
                                }
                                else                                                                    //иначе (если колонка Прибыль)
                                {
                                    account[stringAccount, columnAccount] = account[stringAccount, 1] - account[stringAccount, 2];   //пишем в Прибыль разность Дохода и Расхода
                                                                                                                                     //xacount[monthAndProfit] = account[stringAccount, columnAccount]; ????
                                                                                                                                     //monthAndProfit++; ????
                                    if (account[stringAccount, columnAccount] <= 20_000)                //если текущее значение Прибыли меньше 20_000
                                    {
                                        monthMinProfit++;                                               //увеличиваем счётчик Месяцев с минимальной Прибылью,
                                    }                                                                   //счётчик будет использоваться далее для работы с массивами ключей и Месяцев для вывода худших Месяцев

                                    if (account[stringAccount, columnAccount] > 0)                      //если текущее значение Прибыли положительное
                                    {
                                        monthWithProfit++;                                              //увеличиваем счётчик Месяцев с положительной Прибылью
                                    }
                                }
                                Console.Write($"{account[stringAccount, columnAccount],20}");           //выводим значение Прибыли с форматированием в 20 символов
                            }
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine($"\nМесяцев с положительной прибылью {monthWithProfit}.");        //выводим число Месяцев с положительной Прибылью

                    var keysAccount = new int[monthMinProfit];                                          //создаём массив ключей длиной montMinProfit, со значениями Прибыли < 20_000
                    var minMonth = new int[monthMinProfit];                                             //создаём массив элементов длиной montMinProfit, со значениями Месяцев соответсвтующих Прибыли < 20_000

                    for (int stringAccount = 0; stringAccount < account.GetLength(0); stringAccount++)  //перебиараем строки основного массива
                    {
                        if (account[stringAccount, 3] <= 20_000)                                    //если в столбце Прибыль текущей строки, значение меньше или равно 20_000 
                        {


                            keysAccount[monthAndProfit] = account[stringAccount, 3];                             //то в массив ключей кладём это значение (т.о. формируется массив ключей)
                                                                                                                 //                        Console.Write(keysAccount[monthAndProfit] + " ");
                            minMonth[monthAndProfit] = account[stringAccount, 0];                                //и в массив Месяцев кладём значение соответствующего Месяца (т.о. формируется массив Месяцев)
                                                                                                                 //                       Console.Write(minMonth[monthAndProfit] + " ");
                            monthAndProfit++;                                                                    //увеличиваем общий индекс массивов, что бы кол-во Месяцев соответствовало кол-во значений Прибыли
                        }
                        //               Console.WriteLine();
                    }
                    Array.Sort(keysAccount, minMonth);                                                  //применяем сортировку к массиву элементов в соответствии с ключами, получаем отсортированные Месяцы в соответствии с ростом Прибыли
                    Console.Write("Месяцев с худшей прибылью: ");                                       //выводим сообщение 

                    for (int countMinProfit = 0; countMinProfit < 3; countMinProfit++)                                                         //выводим первые три Месяца с минимальной Прибылью
                    {
                        Console.Write($"{minMonth[countMinProfit]} ");
                    }
                    //Console.Write("\nключи ");
                    //for (int countMinProfit = 0; countMinProfit < keysAccount.Length; countMinProfit++)
                    //{

                    //    Console.Write($"{keysAccount[countMinProfit]} ");
                    //}
                    //Console.WriteLine();

                    //блок для проверки совпадающих значений Прибыли

                    int indexTwinMonth = 3;                                                            //вводим переменную индекса для поиска одинаковых значений минимальной Прибыли              

                    for (int countTwin = 2; countTwin < keysAccount.Length; countTwin++)
                    {             //цикл начинается с 2-го индекса 
                        if (keysAccount[countTwin] == keysAccount[indexTwinMonth])                     //если третий элемент массива ключей равен четвёртому, то нашёл совпадение
                        {
                            // Console.WriteLine("равны");
                            Console.Write($"{minMonth[indexTwinMonth]}");                              //добавляю соответствующий Месяц в минимально прибыльные
                            indexTwinMonth++;                                                          //увеличиваю indexTwinMonth для сравнения со следующим значением
                        }
                        //else if (keysAccount[++countTwin] == keysAccount[++indexTwinMonth] && countTwin < keysAccount.Length)
                        //{
                        //    Console.WriteLine("равны");
                        //    Console.WriteLine($"{minMonth[indexTwinMonth]}");
                        //}

                        else                                                               //иначе, если нет одинаковых значений, то прерываю цикл
                        {
                            break;

                        }
                    }
                    Console.WriteLine("\n");
                    break;
                #endregion
                case 2:
                    #region Решение задачи 2  
                    int k = 1;
                    int n;

                    Console.WriteLine("Введите n");
                    n = Convert.ToInt32(Console.ReadLine());
                    int formatOut = n;                    // вводим переменную formatOut и присваиваем ей значение кол-ва строк для форматированного вывода треугольника
                    int[][] jaggedArray = new int[n][];         

                    for (int i = 0; i < n; i++)
                    {
                        for (int q = 1; q < formatOut; q++) {     // вывод пробелов в зависимости от числа строк      
                            Console.Write("    ");                        
                        }
                        formatOut--;                              // уменьшаем число пробелов

                        jaggedArray[i] = new int[i];

                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            if (i > 2 && j >= 1 && jaggedArray[i].Length - 1 > j)
                            {
                                jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
                            }
                            jaggedArray[i][jaggedArray[i].Length-1] = k;
                            jaggedArray[i][0] = k;
                            Console.Write($"{jaggedArray[i][j]}       ");                          
                        }                       
                        Console.WriteLine();
                    }
                    break;
                #endregion
                case 3:
                    #region Решение задачи 3
                    Console.WriteLine("Введите номер подзадачи:");
                    Console.WriteLine("1 - умножение матрицы на число;");
                    Console.WriteLine("2 - сложение и вычитание матриц;");
                    Console.WriteLine("3 - умножение матриц;");
                    int subNumbTask = Convert.ToInt32(Console.ReadLine());
                    switch (subNumbTask)
                    {

                        case 1:
                            int stringMatrix, columnMatrix, stringMatrix1, columnMatrix1, multiplier;       //инициализируем переменные для ввода строк и столбцов массива 1 и массива 2, 
                                                                                                            //и переменную для ввода числа, на которое будем умножать
                            while (true)                                                                    //цикл для ввода строк и столбцов первой и второй матрицы с условием
                            {
                                Console.WriteLine("Введите количество строк первой матрицы: ");
                                stringMatrix = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество столбцов первой матрицы: ");
                                columnMatrix = Convert.ToInt32(Console.ReadLine());

                                if (stringMatrix > 0 && columnMatrix > 0) //если значения положительные, то продолжаем программу, иначе ввод по новой
                                {
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Неправильный ввод! Введите положительные числа!");

                                }
                            }

                            Console.WriteLine("Введите целое число на которое будем умножать: ");
                            multiplier = Convert.ToInt32(Console.ReadLine());           //считаем число на которое будем умножать              

                            int[,] matrix = new int[stringMatrix, columnMatrix];            //создаём массив 1 
                           
                            int[,] matrixThree = new int[stringMatrix, columnMatrix];      //создаём результирующий массив

                            Random rndm = new Random();                                     //вводим генератор случайных чисел
                            Console.WriteLine("массив 1");                                  //заполняем первый массив
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] = rndm.Next(1, 9);
                                    Console.Write($"{matrix[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine($"Массив после умножения на {multiplier}");   //блок для умножения массива на число
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] *= multiplier;                              //умножаем каждый элемент массива 1 на число, введённое пользователем
                                    Console.Write($"{matrix[i, j]} ");                       //выводим получившийся массив
                                }
                                Console.WriteLine();
                            }
                        
                            break;

                        case 2:
                          
                            while (true)                                                                    //цикл для ввода строк и столбцов первой и второй матрицы с условием
                            {
                                Console.WriteLine("Введите количество строк первой матрицы: ");
                                stringMatrix = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество столбцов первой матрицы: ");
                                columnMatrix = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество строк второй матрицы: ");
                                stringMatrix1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество столбцов второй матрицы: ");
                                columnMatrix1 = Convert.ToInt32(Console.ReadLine());
                                if (stringMatrix > 0 && columnMatrix > 0 && stringMatrix1 > 0 && columnMatrix1 > 0) //если значения положительные, то продолжаем программу, иначе ввод по новой
                                {
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Неправильный ввод! Введите положительные числа!");

                                }
                            }
                            matrix = new int[stringMatrix, columnMatrix];
                            int[,] matrixTwo = new int[stringMatrix1, columnMatrix1];       //создаём массив 2
                            matrixThree = new int[stringMatrix, columnMatrix];      //создаём результирующий массив
                            Random rndm2 = new Random();                                     //вводим генератор случайных чисел
                            Console.WriteLine("массив 1");                                  //заполняем первый массив
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] = rndm2.Next(1, 9);
                                    Console.Write($"{matrix[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("массив 2");                                  //заполняем второй массив
                            for (int i = 0; i < matrixTwo.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                                {
                                    matrixTwo[i, j] = rndm2.Next(1, 9);
                                    Console.Write($"{matrixTwo[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            //Массив после вычитания матриц                                                     //блок вычитания матриц
                                Console.WriteLine("Массив после вычитания матриц:");
                                   for (int i = 0; i < matrixThree.GetLength(0); i++) {
                                       for (int j = 0; j < matrixThree.GetLength(1); j++) {
                                            matrixThree[i,j] = matrix[i, j] - matrixTwo[i, j];
                                            Console.Write($"{matrixThree[i, j],2} ");
                                            }
                                       Console.WriteLine();
                                       }
                            //Массив после сложения матриц                                                      //блок сложения матриц
                               Console.WriteLine("Массив после сложения матриц:");
                                 for (int i = 0; i < matrixThree.GetLength(0); i++)
                                 {
                                     for (int j = 0; j < matrixThree.GetLength(1); j++)
                                     {
                                         matrixThree[i, j] = matrix[i, j] + matrixTwo[i, j];
                                         Console.Write($"{matrixThree[i, j],2} ");
                                     }
                                     Console.WriteLine();
                                 }
                            break;

                        case 3:
                            while (true)                                                                    //цикл для ввода строк и столбцов первой и второй матрицы с условием
                            {
                                Console.WriteLine("Введите количество строк первой матрицы: ");
                                stringMatrix = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество столбцов первой матрицы: ");
                                columnMatrix = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество строк второй матрицы: ");
                                stringMatrix1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Введите количество столбцов второй матрицы: ");
                                columnMatrix1 = Convert.ToInt32(Console.ReadLine());
                                if (stringMatrix > 0 && columnMatrix > 0 && stringMatrix1 > 0 && columnMatrix1 > 0) //если значения положительные, то продолжаем программу, иначе ввод по новой
                                {
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Неправильный ввод! Введите положительные числа!");

                                }
                            }
                            matrix = new int[stringMatrix, columnMatrix];
                            matrixTwo = new int[stringMatrix1, columnMatrix1];
                            matrixThree = new int[stringMatrix, columnMatrix];      //создаём результирующий массив
                            Random rndm3 = new Random();
                            Console.WriteLine("массив 1");                                  //заполняем первый массив
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] = rndm3.Next(1, 9);
                                    Console.Write($"{matrix[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("массив 2");                                  //заполняем второй массив
                            for (int i = 0; i < matrixTwo.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                                {
                                    matrixTwo[i, j] = rndm3.Next(1, 9);
                                    Console.Write($"{matrixTwo[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine("Массив после умножения матриц с одинаковым количеством строк и столбцов");   // блок умножения массива на массив с одинаковым количеством строк и столбцов
                            for (int i = 0; i < matrixThree.GetLength(0); i++)
                            {
                                if (stringMatrix1 != stringMatrix || columnMatrix != columnMatrix1) { Console.WriteLine("Неправильные значения строк и столбцов"); break; }  //условие при котором обязательно равенство строк и столбцов массивов
                                for (int j = 0; j < matrixThree.GetLength(1); j++)
                                {
                                    matrixThree[i, j] = matrix[i, j] * matrixTwo[i, j];   //умножаем текущий элемент массива 1 на текущий элемент массива 2 и кладём в масссив 3
                                    Console.Write($"{matrixThree[i, j]} ");
                                }
                                Console.WriteLine();
                            }

                            int sum = 0;                               //создаём переменную для суммирования результатов умножения элементов массивов

                            Console.WriteLine($"Значение после умножения матрицы одной строки на матрицу в несколько строк при одном столбце");
                            for (int i = 0; i < matrixThree.GetLength(0); i++)
                            {
                                matrixThree[i, 0] = matrix[0, i] * matrixTwo[i, 0];   //результат перемножения элемента массива 1 на элемент массива 2
                                sum = matrixThree[i, 0] + sum;                        //сумма элементов массива 3
                                Console.WriteLine();
                            }
                            Console.WriteLine($"Результат {sum}");
                            break;
                    }
                    break;
            }

        }
  
        #endregion
    }
}
    








// Проверяем, если Прибыль <= 20_000 то собираем один массив из Месяцев, а второй из Прибылей

//for (int countTwin = 0; countTwin < 3; countTwin++)
//{
//    for (indexTwinMonth = 1; indexTwinMonth < keysAccount.Length; indexTwinMonth++)
//    {
//        if (keysAccount[countTwin] == keysAccount[indexTwinMonth] && indexTwinMonth < (keysAccount.Length-1))
//        {
//            Console.WriteLine($"элементы {keysAccount[countTwin]} и {keysAccount[indexTwinMonth]} равны");
//            Console.WriteLine(countTwin);
//            Console.WriteLine(indexTwinMonth);
//            continue;
//        }
//        else
//        {
//            //Console.WriteLine($"элементы {keysAccount[countTwin]} и {keysAccount[indexTwinMonth]} не равны!");

//        }
//    }
//}