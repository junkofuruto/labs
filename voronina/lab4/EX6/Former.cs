using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace EX6
{
    /// <summary>
    /// Класс, хранящий промежуточные данные от соседях
    /// </summary>
    internal class Neighbor
    {
        /// <summary>
        /// Значение
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Соседи
        /// </summary>
        public int[] Neighbors { get; set; }
    }
    internal class Former
    {
        private int[][] _matrix;

        /// <summary>
        /// Конструктор, принимающий матрицу значений для
        /// </summary>
        /// <param name="matrix">Матрица</param>
        public Former(int[][] matrix)
        {
            _matrix = matrix;
        }

        /// <summary>
        /// Метод формирует логическую матрицу, отображающую, является ли число наибольшим среди соседей
        /// </summary>
        /// <returns>Логическая матрица</returns>
        public bool[,] FormLogicMatrix()
        {
            // Циклом прохожу по результату метода GetNeighbors, получая каждый элемент и добаляя
            // их в лист, в соответвии с заданием, далее массив конвертируется в матрицу методом ToMatrix

            List<bool> bitArray = new List<bool>();
            foreach (Neighbor neighbor in GetNeighbors())
            {
                bitArray.Add(neighbor.Neighbors.Any(x => neighbor.Value <= x) == false);
            }

            return ToMatrix(bitArray.ToArray(), _matrix.Length);
        }

        /// <summary>
        /// Метод конвертирующий массив в матрицу, разделяя его на строки
        /// </summary>
        /// <param name="arr">Входной массив</param>
        /// <param name="rows">Количество строк</param>
        private bool[,] ToMatrix(bool[] arr, int rows)
        {
            var cols = arr.Length / rows;
            var m = new bool[rows, cols];
            for (var i = 0; i < arr.Length; i++)
                m[i / cols, i % cols] = arr[i];
            return m;
        }

        /// <summary>
        /// Метод осуществляет поиск соседей каждого элемента и возвращает их в виде
        /// промежуточных данных представленных классом Neighbor
        /// </summary>
        /// <returns></returns>
        private Neighbor[] GetNeighbors()
        {
            List<Neighbor> neighbors = new List<Neighbor>();
            for (int i = 0; i < _matrix.Length; i++)
            {
                for (int j = 0; j < _matrix[0].Length; j++)
                {
                    Neighbor neighbor = new Neighbor();
                    List<int> nears = new List<int>();

                    if (i > 0) nears.Add(_matrix[i - 1][j]);
                    if (i < _matrix.Length - 1) nears.Add(_matrix[i + 1][j]);
                    if (j > 0) nears.Add(_matrix[i][j - 1]);
                    if (j < _matrix[0].Length - 1) nears.Add(_matrix[i][j + 1]);

                    neighbor.Value = _matrix[i][j];
                    neighbor.Neighbors = nears.ToArray();
                    neighbors.Add(neighbor);
                }
            }
            MessageBox.Show(string.Join("\n", neighbors.Select(x => $"[{x.Value}] {string.Join("; ", x.Neighbors)}")));
            return neighbors.ToArray();
        }
    }
}
