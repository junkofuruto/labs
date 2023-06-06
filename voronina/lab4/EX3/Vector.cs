using System;

namespace EX3
{
    /// <summary>
    /// Представляет ошибки, вызванные в случае недосягаемости инекса
    /// </summary>
    internal class VectorOutOfRangeException : Exception
    {
        public VectorOutOfRangeException() : base() { }
        public VectorOutOfRangeException(string message) : base(message) { }
    }
    /// <summary>
    /// Представляет ошибки, вызванные в случае неравности векторов при арифметических операциях с ними
    /// </summary
    internal class VectorNotSimilarLengthException : Exception
    {
        public VectorNotSimilarLengthException() : base() { }
        public VectorNotSimilarLengthException(string message) : base(message) { }
    }

    /// <summary>
    /// Класс вектра, хранящий целые числа и позволяющий производить операции с ним
    /// </summary>
    internal class Vector : object
    {
        private int[] _values;
        private int _length;

        /// <summary>
        /// Конструктор по умолчанию, устанавливающий количество элементов вектора
        /// </summary>
        /// <param name="length">Количество элементов</param>
        public Vector(int length)
        {
            _values = new int[length];
            _length = length;
        }

        /// <summary>
        /// Свойство предоставляющее количество элементов вектора
        /// </summary>
        public int Length
        {
            get => _length;
        }

        /// <param name="i">Индекс</param>
        /// <returns>Элемент с индексом i</returns>
        /// <exception cref="VectorOutOfRangeException"></exception>
        public int this[int i]
        {
            get
            {
                if (i >= _length)
                {
                    throw new VectorOutOfRangeException();
                }
                return _values[i];
            }
            set
            {
                if (i >= _length)
                {
                    throw new VectorOutOfRangeException();
                }
                _values[i] = value;
            }
        }

        /// <summary>
        /// Складывает элементы вектора соответсвенно каждый с каждым
        /// </summary>
        /// <param name="v1">Первый вектор</param>
        /// <param name="v2">Второй вектор</param>
        /// <returns>Результирующий вектор</returns>
        /// <exception cref="VectorNotSimilarLengthException"></exception>
        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1.Length != v1.Length)
            {
                throw new VectorNotSimilarLengthException();
            }
            Vector vector = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                vector[i] = v1[i] + v2[i];
            }

            return vector;
        }

        /// <summary>
        /// Вычитает элементы вектора соответсвенно каждый с каждым
        /// </summary>
        /// <param name="v1">Первый вектор</param>
        /// <param name="v2">Второй вектор</param>
        /// <returns>Результирующий вектор</returns>
        /// <exception cref="VectorNotSimilarLengthException"></exception>
        public static Vector operator -(Vector v1, Vector v2)
        {
            if (v1.Length != v1.Length)
            {
                throw new VectorNotSimilarLengthException();
            }
            Vector vector = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                vector[i] = v1[i] - v2[i];
            }

            return vector;
        }

        /// <summary>
        /// Умножает элементы вектора на скаляр
        /// </summary>
        /// <param name="v1">Первый вектор</param>
        /// <param name="value">Скаляр</param>
        /// <returns>Результирующий вектор</returns>
        /// <exception cref="VectorNotSimilarLengthException"></exception>
        public static Vector operator *(Vector v1, int value)
        {
            if (v1.Length != v1.Length)
            {
                throw new VectorNotSimilarLengthException();
            }
            Vector vector = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                vector[i] = v1[i] * value;
            }

            return vector;
        }
        /// <summary>
        /// Делит элементы вектора соответсвенно каждый с каждым
        /// </summary>
        /// <param name="v1">Первый вектор</param>
        /// <param name="value">Скаляр</param>
        /// <returns>Результирующий вектор</returns>
        /// <exception cref="VectorNotSimilarLengthException"></exception>
        public static Vector operator /(Vector v1, int value)
        {
            if (v1.Length != v1.Length)
            {
                throw new VectorNotSimilarLengthException();
            }
            Vector vector = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                vector[i] = v1[i] / value;
            }

            return vector;
        }

        /// <summary>
        /// Метод возвращает элементы вектора представленные в строковом виде 
        /// </summary>
        /// <returns>a; b; c; d; ...; n;</returns>
        public override string ToString()
        {
            return string.Join("; ", _values);
        }
    }
}