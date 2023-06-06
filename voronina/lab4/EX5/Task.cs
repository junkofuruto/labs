using System.Linq;

namespace EX5
{
    /// <summary>
    /// Класс, реализующий статические методы в соответсвии с заданием
    /// </summary>
    internal static class Task
    {
        /// <summary>
        /// Создает третий массив такого же размера, каждый элемент которого равен 100, 
        /// если соответствующие элементы двух первых массивов 
        /// имеют одинаковый знак, и равен нулю в противном случае;
        /// </summary>
        /// <param name="arr1">Первый массив</param>
        /// <param name="arr2">Второй массив</param>
        /// <returns>Результирующий массив</returns>
        public static int[] FirstExercise(int[] arr1, int[] arr2)
        {
            int[] arr;
            if (arr1.Where(x => x < 0).Count() > 0 || arr2.Where(x => x < 0).Count() > 0)
                arr = Enumerable.Repeat(0, arr1.Length).ToArray();
            else
                arr = Enumerable.Repeat(100, arr1.Length).ToArray();

            return arr;
        }

        /// <summary>
        /// Создает третий массив такого же размера, каждый элемент которого
        /// равен 13, если оба соответствующих элемента двух первых массивов
        /// больше 50, и равен 12 в противном случае.
        /// </summary>
        /// <param name="arr1">Первый массив</param>
        /// <param name="arr2">Второй массив</param>
        /// <returns>Результирующий массив</returns>
        public static int[] SecondExercise(int[] arr1, int[] arr2)
        {
            int[] arr;
            if (arr1.Where(x => x > 50).Count() > 0 || arr2.Where(x => x > 50).Count() > 0)
                arr = Enumerable.Repeat(13, arr1.Length).ToArray();
            else
                arr = Enumerable.Repeat(12, arr1.Length).ToArray();

            return arr;
        }
    }
}
