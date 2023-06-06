using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Room
    {
        private double _width;
        private double _heigth;
        private double _length;
        private int _windowsCount;

        /// <summary>
        /// Конструктор, задающий параметры комнаты
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="heigth">Высота</param>
        /// <param name="length">Длина</param>
        /// <param name="windowsCount">Количество окон</param>
        public Room(double width, double heigth, double length, int windowsCount)
        {
            Width = width;
            Heigth = heigth;
            Length = length;
            WindowsCount = windowsCount;
        }

        /// <summary>
        /// Свойство, возвращающее ширину комнаты
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректное значение ширины");
                }
                _width = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее высоты комнаты
        /// </summary>
        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректное значение высоты");
                }
                _heigth = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее длины комнаты
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректное значение длины");
                }
                _length = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее количество окон
        /// </summary>
        public int WindowsCount
        {
            get
            {
                return _windowsCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректное значение количества окон");
                }
                _windowsCount = value;
            }
        }

        /// <summary>
        /// Метод возвращающий площадь комнаты
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Width * Length;
        }

        /// <summary>
        /// Метод возвращающий объем комнаты
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            return Width * Length * Heigth;
        }
    }
}
