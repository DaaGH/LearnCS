using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    struct Repository
    {

        private Worker[] workers; // Основной массив для хранения данных

        private string path; // путь к файлу с данными

        int index; // текущий элемент для добавления в workers

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Path">Путь в файлу с данными</param>
        public Repository(string Path)
        {
            this.path = Path; // Сохранение пути к файлу с данными
            this.index = 0; // текущая позиция для добавления сотрудника в workers
            this.workers = new Worker[1]; // инициализаия массива сотрудников.    | изначально предпологаем, что данных нет
            this.Load(); // Загрузка данных из файла в массив структур работников
        }

        /// <summary>
        /// Метод увеличения текущего хранилища
        /// </summary>
        /// <param name="Flag">Условие увеличения</param>
        private void Resize(bool Flag)
        {
            if (Flag)  // если результат условия на строке 49 true, то
            {
                Array.Resize(ref this.workers, this.workers.Length * 2); // увеличение длинны массива структур работников в 2 раза
            }
        }

        /// <summary>
        /// Метод добавления сотрудника в хранилище при Load()
        /// </summary>
        /// <param name="ConcreteWorker">Сотрудник</param>
        public void Add(Worker ConcreteWorker)
        {
            this.Resize(index >= this.workers.Length); // проверка хватает ли места в массиве 
            this.workers[index] = ConcreteWorker;   // добавление работника в массив                   
            this.index++;  // увеличиваем индекс для добавления следующего работника  
        }
        /// <summary>
        /// Метод добавления сотрудника в справочник
        /// </summary>
        /// <param name="ConcreteWorker"></param>
        public void AddIn(Worker ConcreteWorker) //
        {
            this.Resize(index >= this.workers.Length); // проверка хватает ли места в массиве 
            this.workers[index] = ConcreteWorker;   // добавление работника в массив                    
            this.index++;  // увеличиваем индекс для добавления следующего работника
            string[] temp = new string[index];                // для того что бы после добавления сохранить в случае только что созданного файла
            for (int i = 0; i < index; i++)
            {
                temp[i] = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",  // пишем в массив поля сотрудников
                                                this.workers[i].ID,
                                                this.workers[i].AddEntReal,
                                                this.workers[i].Name,
                                                this.workers[i].Age,
                                                this.workers[i].Height,
                                                this.workers[i].DateOfBirth,
                                                this.workers[i].PlaceOfBirth);
            }
            File.WriteAllLines(this.path, temp);  // записать данные из массива temp в файл
        }
        /// <summary>
        /// Метод загрузки данных
        /// </summary>
        private void Load()
        {
            using (StreamReader sr = new StreamReader(this.path))  // открыли поток считывания из файла
            {
                while (!sr.EndOfStream)     // пока не конец файла.
                {
                    string[] args = sr.ReadLine().Split('#');   // считывание строки из файла и разделение её в массив
                    if (args[0] == "")
                    {
                        continue;
                    }
                    else if (args[0] == null) { // если файл только создан завершаем, тк он пустой
                        break;
                    }
                    else
                    {
                        Add(new Worker(Convert.ToInt32(args[0]), args[2], Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToDateTime(args[5]), args[6], Convert.ToDateTime(args[1])));
                        // добавляем нового работника с полями из полученного массива
                    }

                }
            }
        }
        /// <summary>
        /// Метод сортировки данных
        /// </summary>        
        public void Sort()
        {

            Console.WriteLine("Сортировка по ID");
            var sorted = workers.OrderBy(w => w.ID); // сортируем массив работников по ID
            foreach (var worker in sorted)
            {
                if (worker.ID != 0)
                    Console.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",    // выводим результат в консоль без сохранения в файл
                                          worker.ID,                    // алгоритм практически одинаковый у всех сорировок
                                          worker.AddEntReal,
                                          worker.Name,
                                          worker.Age,
                                          worker.Height,
                                          worker.DateOfBirth,
                                          worker.PlaceOfBirth);
            }
            Console.WriteLine("Сортировка по возрасту");
            sorted = workers.OrderBy(w => w.Age);
            foreach (var worker in sorted)
            {
                if (worker.Age != 0)
                    Console.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                          worker.ID,
                                          worker.AddEntReal,
                                          worker.Name,
                                          worker.Age,
                                          worker.Height,
                                          worker.DateOfBirth,
                                          worker.PlaceOfBirth);
            }
            Console.WriteLine("Сортировка по имени");
            sorted = workers.OrderBy(w => w.Name);
            foreach (var worker in sorted)
            {
                if (worker.Name != null)
                    Console.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                          worker.ID,
                                          worker.AddEntReal,
                                          worker.Name,
                                          worker.Age,
                                          worker.Height,
                                          worker.DateOfBirth,
                                          worker.PlaceOfBirth);
            }
            Console.WriteLine("Сортировка по дате рождения");
            sorted = workers.OrderBy(w => w.DateOfBirth);
            foreach (var worker in sorted)
            {
                if (worker.ID != 0)         // без разницы по какому полю проверяем 
                    Console.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                          worker.ID,
                                          worker.AddEntReal,
                                          worker.Name,
                                          worker.Age,
                                          worker.Height,
                                          worker.DateOfBirth,
                                          worker.PlaceOfBirth);

            }
            Console.WriteLine("Сортировка по росту");
            sorted = workers.OrderBy(w => w.Height);
            foreach (var worker in sorted)
            {
                if (worker.ID != 0)
                    Console.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                          worker.ID,
                                          worker.AddEntReal,
                                          worker.Name,
                                          worker.Age,
                                          worker.Height,
                                          worker.DateOfBirth,
                                          worker.PlaceOfBirth);

            }
            Console.WriteLine("Сортировка по дате добавления");
            sorted = workers.OrderBy(w => w.AddEntReal);
            foreach (var worker in sorted)
            {
                if (worker.ID != 0)
                    Console.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                                          worker.ID,
                                          worker.AddEntReal,
                                          worker.Name,
                                          worker.Age,
                                          worker.Height,
                                          worker.DateOfBirth,
                                          worker.PlaceOfBirth);

            }
        }

        /// <summary>
        /// Удаление записи из справочника
        /// </summary>
        /// <param name="Path"></param>
        public void Del(string Path)
        {
            Console.WriteLine("Введите id записи для удаления: ");
            int id = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[index];   // массив в который пишутся все данные из справочника 
            string[] temp = new string[index];  // массив в который запишем все данные из справочника, кроме строки которую нужно удалить по id
            using (StreamReader sr = new StreamReader(this.path))
            {
                //вводим индексы для правильного заполнения справочника после удаления
                int j = 0;
                int i = 0;
                int k = 0;
   
                while (!sr.EndOfStream)

                {
                    arr = sr.ReadLine().Split('#');

                    if (arr[i] != "" && Convert.ToInt32(arr[i]) != id) // проверка равен ли считанный id введённому пользователем и нет ли пустой строки
                    {
                        temp[k] = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}", // заполняем массив temp необходимыми данными, исключив id записи для удаления
                                      this.workers[j].ID,
                                      this.workers[j].AddEntReal,
                                      this.workers[j].Name,
                                      this.workers[j].Age,
                                      this.workers[j].Height,
                                      this.workers[j].DateOfBirth,
                                      this.workers[j].PlaceOfBirth); 
                        j++; // увеличиваем счётики
                        k++;
                    }
                    else {
                        j++; // при нахождении id увеличиваем счётчик и пропускаем уаляемую запись
                        continue;
                    }
                }

                Load();
            }
            File.WriteAllLines(Path, temp); // перезапишем файл со справочником после удаления
           
        }


        /// <summary>
        /// Метод сохранения данных
        /// </summary>
        /// <param name="Path">Путь к файлу сохранения</param>
        public void Save(string Path)   // сохранение справочника
        {
            string[] temp = new string[this.index];
            using (StreamReader sr = new StreamReader(this.path))
            {
                while (!sr.EndOfStream)
                {
                    string[] arr = new string[index];
                    arr = sr.ReadLine().Split('#');     // после добавления строк 209-214 стал писать время добавления, думаю из-за того что поток открыт и не даёт редакт.
                    //string[] temp = new string[index];

                    for (int i = 0; i < this.index; i++)
                    {
                        temp[i] = String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}",  // пишем в массив поля сотрудников
                                                this.workers[i].ID,
                                                this.workers[i].AddEntReal,
                                                this.workers[i].Name,
                                                this.workers[i].Age,
                                                this.workers[i].Height,
                                                this.workers[i].DateOfBirth,
                                                this.workers[i].PlaceOfBirth);
                    }
                }
            }
            File.WriteAllLines(Path, temp);     // переписываем весь файл массивом сотрудников
        }

        /// <summary>
        /// Печать справочника в консоль
        /// </summary>
        public void PrintDbToConsole()  
        {
            using (StreamReader sr = new StreamReader(this.path))   // считываем файл в поток
            {           
                while (!sr.EndOfStream)    // пока не конец потока 

                {
                    string[] lines = sr.ReadLine().Split('#');  // считываем строки в массив
                    if (lines[0] == "") { continue; }
                    foreach (var line in lines) {   
                        Console.Write($"{line}#");    // выводим данные из массива в консоль

                    }
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// Вывод информации о записи по id
        /// </summary>
        public void Printid(int id) // тоже что и PrintDbToConsole(), только сравниваем первый элемент массива(id) считанного из файла со введённым пользователем
        {           
            using (StreamReader sr = new StreamReader(this.path))
            {
                int i = 0;
                
                while (!sr.EndOfStream)

                {
                    string[] lines = sr.ReadLine().Split('#');
                    if (lines[i] == "") { continue; }
                    if (Convert.ToInt32(lines[i]) == id)
                    {                        
                        foreach (var line in lines)
                        {
                            Console.Write($"{line}#");                            
                        }
                    }                                      
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Вывод информации в выбраном дапазоне дат
        /// </summary>
        public void GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo) // на вход подадим дату от и дату до
        {            
            using (StreamReader sr = new StreamReader(this.path))
            {
                Console.WriteLine("Вывод между двумя датами");
                int i = 1;
             
                while (!sr.EndOfStream)
                   
                {
                    string[] lines = sr.ReadLine().Split('#');
                    if (lines[0] == "") { continue; }
                    if (Convert.ToDateTime(lines[i]) > dateFrom && Convert.ToDateTime(lines[i]) < dateTo)
                    {
                        foreach (var line in lines)
                        {
                            Console.Write($"{line}#");                                                      
                        }
                        Console.Write("\n");
                    }
                }                
            }
        }

        //public void PrintId()  // редактирование записи 
        //{
        //    Console.WriteLine("Введите id записи для редактирования: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"{this.workers[id].ID} {this.workers[id].AddEnt} {this.workers[id].Name} {this.workers[id].Age} {this.workers[id].Height} {this.workers[id].DateOfBirth} {this.workers[id].PlaceOfBirth}");
        //}


        ///// <summary>
        ///// Количество сотрудников в хранилище
        ///// </summary>
        //public int Count { get { return this.index; } }


    }
}

