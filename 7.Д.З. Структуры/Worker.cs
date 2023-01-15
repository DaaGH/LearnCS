
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    struct Worker
    {
        #region Конструкторы

        /// <summary>
        /// Создание сотрудника
        /// </summary>
        /// <param name="ID">Идентификатор</param>
        /// <param name="AddEnt">Дата и время добавления записи для ввода</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateOfBirth">Дата рождения</param>
        /// <param name="PlaceOfBirth">Место рождения</param>
        /// <param name="AddEntReal">Дата и время добавления записи неизменяемое для вывода и записи</param>>
        public Worker(int ID, string Name,int Age, int Height, DateTime DateOfBirth, string PlaceOfBirth, DateTime AddEntReal)
        {
            this.iD = ID;
            this.addEnt = DateTime.Now;
            this.name = Name;
            this.age = Age;
            this.height = Height;
            this.dateOfBirth = DateOfBirth;
            this.placeOfBirth = PlaceOfBirth;
            this.addEntReal = AddEntReal;
        }
    #endregion

    #region Свойства

    /// <summary>
    /// Идентификатор
    /// </summary>
    public int ID { get { return this.iD; } set { this.iD = value; } }

        /// <summary>
        /// Дата и время добавления записи
        /// </summary>
        public DateTime AddEnt { get { return this.addEnt; } }/*set { this.addEnt = DateTime.Now; }/ } */

        /// <summary>
        /// Дата и время добавления записи
        /// </summary>
   

        public string Name { get { return this.name; } set { this.name = value; } }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get { return this.age; } set { this.age = value; } }

        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get { return this.height; } set { this.height = value; } }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get { return this.dateOfBirth; } set { this.dateOfBirth = value; } }

        public DateTime AddEntReal { get { return this.addEntReal; } set { this.addEntReal = value; } }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public string PlaceOfBirth { get { return this.placeOfBirth; } set { this.placeOfBirth = value; } }
        #endregion

        #region Поля

        /// <summary>
        /// Поле "Идентификатор"
        /// </summary>
        private int iD;

        /// <summary>
        /// Поле "Дата и время добавления записи"
        /// </summary>
        private DateTime addEnt;

        private DateTime addEntReal;

        private string name;

        /// <summary>
        /// Поле "Возраст"
        /// </summary>
        private int age;

        /// <summary>
        /// Поле "Рост"
        /// </summary>
        private int height;

        /// <summary>
        /// Поле "Дата рождения"
        /// </summary>
        private DateTime dateOfBirth;

        /// <summary>
        /// Поле "Место рождения"
        /// </summary>
        private string placeOfBirth;

        #endregion
        #region Методы
                public string Print()
        {
            return $"{this.iD,5} {this.name,15} {this.addEnt,15} {this.age,5} {this.height,5} {this.dateOfBirth,15} {this.placeOfBirth,20}";
        }
        #endregion
    }
}

