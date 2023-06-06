using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    /// <summary>
    /// Класс, хранящмий статические методы соответсвующие заданию
    /// </summary>
    internal static class Task
    {
        /// <summary>
        /// Метод поиска первого отрицательного элемента массива, если таких нет, то возвращается нуль
        /// </summary>
        /// <param name="values">Входной массив</param>
        /// <returns>Отрицательное число из масива</returns>
        public static int GetFirstNegative(int[] values)
        {
            // Циклом прохожу по всему массиву и каждый элемент проверяю
            // на то, что он меньше нуля, если условие проходит, возвращаю число,
            // если нет, то в конце возвращаю нуль

            foreach (int value in values)
            {
                if (value < 0)
                {
                    return value;
                }
            }
            return 0;
        }
        /// <summary>
        /// Метод поиска первого четного элемента массива, если таких нет, то возвращается нуль
        /// </summary>
        /// <param name="values">Входной массив</param>
        /// <returns>Четное число из масива</returns>
        public static int GetLastEven(int[] values)
        {
            // Циклом прохожу по всему массиву и каждый элемент проверяю
            // на то, что он нацело делится на 2, если условие проходит, то возвращаю число,
            // если нет, то в конце возвращаю нуль

            foreach (int value in values.Reverse())
            {
                if (value % 2 == 0)
                {
                    return value;
                }
            }
            return 0;
        }
        /// <summary>
        /// Метод поиска элементов массива, последняя десятичная цифра которых равна target.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] GetValusWithTarget(int[] values, int target)
        {
            // Создаю лист целых чисел, циклом прохожу по массиву и если остаток от деления равен целевой цифре
            // то добавляю его в лист с результатом, в конце возвращаю лисЮ сконвертированный в массив

            List<int> result = new List<int>();
            foreach (int value in values)
            {
                if (value % 10 == target)
                {
                    result.Add(value);
                }
            }
            return result.ToArray();
        }
    }
}
