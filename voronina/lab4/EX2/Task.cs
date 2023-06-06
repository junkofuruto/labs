using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    /// <summary>
    /// Класс хранящий данные о двух строках и метод, 
    /// позволяющий их обработать в соответсвии с заданием
    /// </summary>
    internal class Task
    {
        /// <summary>
        /// Первая строка
        /// </summary>
        public string FirstString { get; private set; }
        /// <summary>
        /// Вторая строка
        /// </summary>
        public string SecondString { get; private set; }

        /// <summary>
        /// Конструктор, который принимает 2 строки и сохраняет их для
        /// последующей обработки
        /// </summary>
        /// <param name="firstString">Первая строка</param>
        /// <param name="secondString">Вторая строка</param>
        public Task(string firstString, string secondString)
        {
            FirstString = firstString;
            SecondString = secondString;
        }

        /// <summary>
        /// Метод обработки строк, который изменяет данные в свойствах
        /// FirstString и SecondString в соответвии с заданием
        /// </summary>
        public void Proceed()
        {
            // Сначала сохраняю количество букв Я в первой строки
            // потом изменяю её, удалив их из неё
            // потом добавляю их к первой строки и в конце дополняю строку до 10 символов символом *
            int valueCount = FirstString.Length - FirstString.Split('я').Length;
            FirstString = string.Join("", FirstString.Split('я'));
            SecondString = SecondString.PadLeft(SecondString.Length + valueCount, 'я');
            FirstString = FirstString.PadRight(10, '*');
            SecondString = SecondString.PadRight(10, '*');
        }
    }
}
