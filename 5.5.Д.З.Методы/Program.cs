using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            //
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
            // 
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
            // Весь код должен быть откоммментирован
            int n = 0;
            int stringMatrix, columnMatrix, stringMatrix1, columnMatrix1, multiplier;                                     //и переменную для ввода числа, на которое будем умножать
            n = printMenu(n);


            #region Вызов функций
            switch (n)
            {
                case 1: //+
                    Console.WriteLine("1 - Матрица на число");
                    Console.WriteLine("2 - Сумма двух матриц");
                    Console.WriteLine("3 - Произведение двух матриц");
                    Console.WriteLine("Введите номер подзадачи");
                    int nn = Convert.ToInt32(Console.ReadLine());
                    switch (nn) {
                        case 1:
                            #region Задача 1.1 Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число                                      

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
                            multiplier = Convert.ToInt32(Console.ReadLine());           //считаем ввод пользователя, число на которое будем умножать              

                            int[,] matrix = new int[stringMatrix, columnMatrix];        //создаём матрицу 1                  

                            matrixOnMultiplier(matrix, multiplier);
                            #endregion
                            break;
                        case 2:
                            #region Задача 1.2 Создать метод, принимающий две матрицы и возвращающий их сумму;
                            while (true)                                                                    //цикл для ввода строк и столбцов первой и второй матрицы с условием
                            {
                                Console.WriteLine("Для умножения матриц количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!!! \n");

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
                            matrix = new int[stringMatrix, columnMatrix];        //создаём матрицу 1
                            int[,] matrix1 = new int[stringMatrix1, columnMatrix1];     //создаём матрицу 2

                            matrixesSumm(matrix, matrix1);  //сумма матриц
                            #endregion
                            break;
                        case 3:
                            #region Задача 1.3 Создать метод, принимающий две матрицы и возвращающий их произведение;
                            while (true)                                                                    //цикл для ввода строк и столбцов первой и второй матрицы с условием
                            {
                                Console.WriteLine("Для умножения матриц количество столбцов первой матрицы должно быть равно количеству строк второй матрицы!!! \n");

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
                            matrix = new int[stringMatrix, columnMatrix];        //создаём матрицу 1
                            matrix1 = new int[stringMatrix1, columnMatrix1];     //создаём матрицу 2
                            int stringResult, columnResult;                             // вводим переменные кол-ва строк и столбцов для матрицы произведения матриц

                            int[] arr = new int[] { stringMatrix, columnMatrix };       //создам одномерный массив и положу туда значения строк и столбцов 1 матрицы
                            int[] arr1 = new int[] { stringMatrix1, columnMatrix1 };    //создам одномерный массив и положу туда значения строк и столбцов 2 матрицы
                            stringResult = arr.Max();  //узнаю что больше число строк или столбцов 1 матрицы и большее положу в число строк матрицы промежуточной
                            columnResult = arr1.Max();  //тоже самое для столбцов

                            int[,] matrixInterim = new int[stringResult, columnResult]; //матрица промежуточная будет иметь размер максимальных значений столбцов и строк
                           
                            matrixesMult(matrix, matrix1, matrixInterim);
                            break;


                    }
                    break;
                #endregion
                #region Задача 2.1 и 2.2
                case 2:
                        Console.WriteLine("Самое длинное и самое короткое слово в пользовательском вводе.");
                        string text;
                        Console.WriteLine("Введите текст:");
                        text = Console.ReadLine();
                        Console.WriteLine($"Самое короткое слово {searchMinWord(text)}");  // выводим самое короткое слово
                        Console.WriteLine($"Самое длинное слово {searchMaxWord(text)}");   // выводим самое длинное слово
                  
                    break;
                #endregion
                #region Задача 3
                case 3:
                    Console.WriteLine("Удаление повторяющихся символов.");
                    string userText;
                    Console.WriteLine("Введите текст:");
                    userText = Console.ReadLine();
                    Console.WriteLine($"Текст после удаления повторяющихся символов {delOfRepeat(userText)}");

                    break;
                #endregion
                #region Задача 4
                case 4:
                    Console.WriteLine("Арифметическая или геометрическая?");
                    Console.WriteLine("Введите последовательность чисел через пробел");
                 string seq = Console.ReadLine();
                    arithmProgr(seq);
                    geomProgr(seq);
                    break;
                #endregion
                #region Задача 5
                case 5:
                    Console.WriteLine("Вычисление функции Аккермана");
                    Console.WriteLine($"{A(1, 2)}");
                    Console.WriteLine($"{A(2, 5)}");
                    break;
                #endregion
                #region Задача 6
                case 6:
                    Console.WriteLine("Разделение строки на слова");
                    Console.WriteLine("Введите текст:");
                    string userString = Console.ReadLine();                   
                    string[] array = GetArrayOfUserString(userString);
                    GetWordOfArray(array);
                    break;
                #endregion
                #region Задача 7
                case 7:
                    Console.WriteLine("Перестановка слов в предложении");
                    Console.WriteLine("Введите текст:");
                    userString = Console.ReadLine();                   
                    ReverseWords(userString);                    
                    break;
            }
        }
        #endregion
        #endregion
        #region Описание функций
        //Методы задач
        /// <summary>
        /// Метод выводящий меню с задачами
        /// </summary>
        static int printMenu(int n) {
            Console.WriteLine("1 - Задание 1. Операции с матрицами");
            Console.WriteLine("2 - Задание 2. Самое длинное и самое короткое слово в пользовательском вводе.");
            Console.WriteLine("3 - Задание 3. Удаление повторяющихся символов.");
            Console.WriteLine("4 - Задание 4. Арифметическая или геометрическая?");
            Console.WriteLine("5 - Задание 5. Вычисление функции Аккермана");
            Console.WriteLine("6 - Задание 6. Разделение строки на слова");
            Console.WriteLine("7 - Задание 7. Перестановка слов в предложении");
            Console.WriteLine("Выберите номер задачи:");
           return n = Convert.ToInt32(Console.ReadLine());
        }
        static void initMatrix(int[,] matrix) {                             //ф-ия инициализации массива

            
            Random rndm = new Random();                                     //вводим генератор случайных чисел
            Console.WriteLine("Исходная матрица");                          //заполняем первый массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rndm.Next(1, 9);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void matrixOnMult(int[,]matrix,int[,] matrixResult, int multiplier)  // ф-ия умножения матрицы на число
        {
            Console.WriteLine($"Матрица после умножения на число {multiplier}");   //блок для умножения массива на число
            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix[i, j] * multiplier;                //умножаем каждый элемент массива 1 на число, введённое пользователем
                    Console.Write($"{matrixResult[i, j]} ");                       //выводим получившийся массив
                }
                Console.WriteLine();
            }
        }

        static void originalMatrix(int[,] matrix)                                   //ф-ия вывода матрицы исходной
        {
            Console.WriteLine("Исходная матрица остаётся без изменений");                                  //заполняем первый массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод умножающий матрицу(matrix) на число(multiplier)
        /// </summary>
        /// <param name="matrix">матрица</param>
        /// <param name="multiplier">число</param>
        static void matrixOnMultiplier(int[,] matrix, int multiplier)
        {
            int[,] matrixResult = new int[matrix.GetLength(0), matrix.GetLength(1)];  //создаём массив с размером массива matrix, который будет матрицей после умножения на число
            
            initMatrix(matrix);

            matrixOnMult(matrix, matrixResult, multiplier);

            originalMatrix(matrix);
            
        }
        /// <summary>
        /// Метод возвращающий сумму матриц matrix и matrix1
        /// </summary>
        /// <param name="matrix">первая матрица</param>
        /// <param name="matrix1">вторая матрица</param>
        static int[,] matrixesSumm(int[,] matrix, int[,] matrix1)
        {
            int[,] matrixResult = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Random rndm = new Random();                                     //вводим генератор случайных чисел
            Console.WriteLine("Матрица 1");                                  //заполняем первый массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rndm.Next(1, 9);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица 2");                                  //заполняем второй массив
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = rndm.Next(1, 9);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Результат сложения двух матриц");   //блок для умножения массива на число
            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix[i, j] + matrix1[i, j];                //умножаем каждый элемент массива 1 на число, введённое пользователем
                    Console.Write($"{matrixResult[i, j]} ");                       //выводим получившийся массив
                }
                Console.WriteLine();
            }

            return matrixResult;
        }
        /// <summary>
        /// Метод возвращающий разность матриц matrix и matrix1
        /// </summary>
        /// <param name="matrix">первая матрица</param>
        /// <param name="matrix1">вторая матрица</param>
        static int[,] matrixesSub(int[,] matrix, int[,] matrix1)
        {
            int[,] matrixResult = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Random rndm = new Random();                                     //вводим генератор случайных чисел
            Console.WriteLine("Матрица 1");                                  //заполняем первый массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rndm.Next(1, 9);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица 2");                                  //заполняем второй массив
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = rndm.Next(1, 9);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Результат вычитания двух матриц");   //блок для умножения массива на число
            for (int i = 0; i < matrixResult.GetLength(0); i++)
            {
                for (int j = 0; j < matrixResult.GetLength(1); j++)
                {
                    matrixResult[i, j] = matrix[i, j] - matrix1[i, j];                //умножаем каждый элемент массива 1 на число, введённое пользователем
                    Console.Write($"{matrixResult[i, j]} ");                       //выводим получившийся массив
                }
                Console.WriteLine();
            }

            return matrixResult;
        }

        /// <summary>
        /// Метод возвращающий произведение матриц matrix и matrix1
        /// </summary>
        /// <param name="matrix">первая матрица</param>
        /// <param name="matrix1">вторая матрица</param>
        /// <param name="matrixInterim">промежуточная матрица</param>
        static int[,] matrixesMult(int[,] matrix, int[,] matrix1, int[,] matrixInterim)
        {
            if (matrix.GetLength(1) != matrix1.GetLength(0))
            {
                Console.WriteLine("Число столбцов матрицы 1 не равно числу строк матрицы 2! Программа завершена.");
                return matrix;
            }
            else
            {
                int n = 0;
                int[,] matrixResult = new int[matrixInterim.GetLength(0), matrixInterim.GetLength(1)]; //размер матрицы произведений есть длины строк и столбцов промежуточной матрицы
                Random rndm = new Random();                                     //вводим генератор случайных чисел
                Console.WriteLine("Матрица 1");                                  //заполняем первый массив
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rndm.Next(1, 9);
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Матрица 2");                                  //заполняем второй массив
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix1[i, j] = rndm.Next(1, 9);
                        Console.Write($"{matrix1[i, j]} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Результат умножения двух матриц");
                for (int i = 0; i < matrixResult.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixResult.GetLength(1); j++)
                    {
                        if (matrix.GetLength(0) > matrix.GetLength(1)) // если строк больше, чем столбцов то вычисляем по этой формуле
                        {
                            matrixResult[i, j] = matrix[i, n] * matrix1[n, j] + matrix[i, n + 1] * matrix1[n + 1, j];
                            Console.Write($"{matrixResult[i, j]} ");                       //выводим получившийся массив
                        }
                        else if (matrix.GetLength(0) < matrix.GetLength(1)) //если строк меньше, чем столбцов то вычисляем по этой формуле
                        {
                            matrixResult[i, j] = matrix[n, i] * matrix1[j, n] + matrix[n + 1, i] * matrix1[j, n + 1];
                            Console.Write($"{matrixResult[i, j]} ");                       //выводим получившийся массив
                        }

                    }
                    Console.WriteLine();
                }

                return matrixResult;
            }

        }

        /// <summary>
        /// Метод возвращающий самое короткое слово из пользовательского ввода
        /// </summary>
        /// <param name="text">пользовательский ввод</param>       
        static string searchMinWord(string text) {

            string[] subs = text.Split(' ');       // создадим массив символьный и заполним его по разделителю "пробел"
            int countChar = subs[0].Length;        // вводим переменную в которую кладём длину первого слова
            string minWord = subs[0];              // вводим переменную в которую кладём первое слово из получившегося массива, считаем его минимальным

            for (int j = 1; j < subs.Length; j++)   //запускаем цикл по сравниванию значений 
            {                
                if (subs[j].Length < countChar)     //если длина текущего слова меньше длины предыдущего слова
                {
                    minWord = subs[j];              //сделать минимальным текущее
                    countChar = subs[j].Length;     //длину текущего кладём в переменную
                }
            }
            return minWord; 
        }
        /// <summary>
        /// Метод возвращающий самое короткое слово из пользовательского ввода
        /// </summary>
        /// <param name="text">пользовательский ввод</param>
        static string searchMaxWord(string text)
        {

            string[] subs = text.Split(' ');        //создадим массив символьный и заполним его по разделителю "пробел"
            int countChar = subs[0].Length;         // вводим переменную в которую кладём длину первого слова
            string maxWord = subs[0];               // вводим переменную в которую кладём первое слово из получившегося массива, стичтаем его максимальным

            for (int j = 1; j < subs.Length; j++)   //запускаем цикл по сравниванию значений
            {
                if (subs[j].Length > countChar)    //если длина текущего слова больше длины предыдущего слова
                {
                    maxWord = subs[j];             //сделать максимальным текущее
                    countChar = subs[j].Length;    //длину текущего кладём в переменную
                }
            }
            return maxWord;
        }
        /// <summary>
        /// Метод удаляющий все повторяющиеся символы из пользовательского ввода
        /// </summary>
        /// <param name="userText">пользовательский ввод</param>
        static string delOfRepeat(string userText)
        {
            char[] subs = userText.ToCharArray();   //преобразуем пользовательский ввод в массив
            char[] subs2 = new char[500];           //создадим второй массив

            int n = 0;
            int j = 0;
            for (int i = 1; i < subs.Length; i++)
            {
               
                if (subs[i] == subs[n])  //если первый равен второму, продолжи цикл
                {
                    if (i == (subs.Length - 1))  //если текущее значение равно последнему индексу массива
                    {   
                        subs2[j] = subs[i];      //положи во второй массив в индекс j значение текущего в первом массиве             
                        break;
                    }                                      
                    continue;
                }
                else if (subs[i] != subs[n])    //иначе, если первый не равен второму
                {
                    subs2[j] = subs[n];         //положи в j массива 2, n массива 1
                    j++;                        //увеличь j
                    n = i;                      //положи в n, текущее i
                    if (n == (subs.Length - 1))    //если n равно последнему индексу массива
                    {
                        subs2[j] = subs[n];        //положи в j массива 2, n масссива 1             
                    }
                }
            }
            string text2 = string.Empty;    //вводим пустую строку
            foreach (char c in subs2)       // запускаем цикл, из всех значений массива 2 формируем результирующую строку из которой удалены повторы
            {
                text2 += c;
            }
            return text2;
        }
        /// <summary>
        /// Метод определяющий является ли введённая последовательность арифметической прогрессией
        /// </summary>
        /// <param name="seq">пользовательский ввод</param>
        static void arithmProgr(string seq) //
        {
            string[] subs = seq.Split(' ');    //создадим массив и положим в него значения из пользовательского ввода, по разделителю "пробел"

            long[] arr2 = new long[subs.Length];  //создадим массив второй, с длиной равной длине массива subs

            for (int i = 0; i < subs.Length; i++)  //запустим цикл в котором каждый элемент массива subs переведём в Int64, заполнив соответственно массив arr2
            {
                arr2[i] = Convert.ToInt64(subs[i]);
            }
            long d = arr2[1] - arr2[0];             //введём переменную в которой сохраним разность первого и второго значений массива arr2, это будет шаг прогрессии
            int f = 2;           // введём переменную и присвоим ей значение 2
            int count = 0;       // введём счётчик
            for (int j = 1; j < (arr2.Length - 1); j++) //цикл для проверки шага прогрессии
            {
                long r = arr2[f] - arr2[j];       //вводим переменную в которую будем класть разность текущего и стледующего элементов массива
                if (r == d)                       //если шаг равен проверочному шагу, то увеличиваем счётчик
                {
                    count++;
                }
                else if (r != d)          //иначе, если не равен прервываем
                {
                    break;
                }

                if (f < (arr2.Length - 1))  // если переменная f менше последнего индекса массива, увеличиваем её на 1
                {
                    f++;
                }
            }
            if (count == (arr2.Length - 2))     //если счётчик равен длине массива-2, то последовательность арифметическая прогрессия
            {
                Console.WriteLine("Последовательность является арифм прогрессией");
            }
            else
            {
                Console.WriteLine("Последовательность не арифм прогрессия");
            }
        }
            /// <summary>
           /// Метод определяющий является ли введённая последовательность геометрической прогрессией
           /// </summary>
           /// <param name="seq">пользовательский ввод</param>
        static void geomProgr(string seq)           //по сути код метода идентичен методу с проверкой на арифм. прогр. за ислючением строк 555 и 560
        {
            string[] subs = seq.Split(' ');          
            long[] arr2 = new long[subs.Length];

            for (int i = 0; i < subs.Length; i++)
            {
                arr2[i] = Convert.ToInt64(subs[i]);
            }
            long d = arr2[1] / arr2[0];     //вычисляем шаг геом. прогрессии
            int f = 2;
            int count = 0;
            for (int j = 1; j < (arr2.Length - 1); j++)
            {
                long r = arr2[f] / arr2[j];     //и тут
                if (r == d)
                {
                    count++;
                }
                else if (r != d)
                {
                    break;
                }

                if (f < (arr2.Length - 1))
                {
                    f++;
                }
            }
            if (count == (arr2.Length - 2))
            {
                Console.WriteLine("Последовательность является геометрической прогрессией");
            }
            else
            {
                Console.WriteLine("Последовательность не геометрическая прогрессия");
            }
        }
        /// <summary>
        /// Метод вычисления функции Аккермана
        /// </summary>
        /// <param name="m">первое число</param>
        /// <param name="n">второе число</param>
        static int A(int n, int m)
        {
            if (n == 0) return m + 1;
            if (n != 0 && m == 0) return A(n - 1, 1);
            if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
            return A(n, m);
        }
        /// <summary>
        /// Метод разделения пользовательского текста в массив
        /// </summary>
        /// <param name="userString">первое число</param>
        static string[] GetArrayOfUserString(string userString)
        {
            string[] array = userString.Split(' ');
            return array;
        }
        /// <summary>
        /// Метод вывода текста из массива построчно
        /// </summary>
        /// <param name="array">первое число</param>
        static void GetWordOfArray(string[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }
        static void ReverseWords(string userString) {
            string[] array1 = GetArrayOfUserString(userString);
            int k = 1;
            for (int i = 0; i < array1.Length; i++)
            {
                if (i > array1.Length - k)
                {
                    break;
                }
                else
                {
                    string temp = array1[i];                    //создал переменную для промежуточного хранения значения
                    array1[i] = array1[array1.Length - k];      //поменял местами текущую с противоположной
                    array1[array1.Length - k] = temp;
                    k++;
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"{array1[i]}");
            }
        }
    }
}
#endregion
