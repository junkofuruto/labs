using System;
using System.Windows;

namespace EX3
{
    internal class Time
    {
        private int _hour;
        private int _minute;
        private int _second;

        /// <summary>
        /// Конструктор, задающий часы, минуты и секунды в параметры
        /// </summary>
        /// <param name="hour">Часы</param>
        /// <param name="minute">Минуты</param>
        /// <param name="second">Секунды</param>
        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        /// <summary>
        /// Час
        /// </summary>
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new Exception("Неверное значение часа");
                }
                _hour = value;
            }
        }

        /// <summary>
        /// Минута
        /// </summary>
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new Exception("Неверное значение минуты");
                }
                _minute = value;
            }
        }

        /// <summary>
        /// Секунда
        /// </summary>
        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new Exception("Неверное значение секунд");
                }
                _second = value;
            }
        }

        /// <summary>
        /// Метод изменяет объект времени на определенное значение
        /// </summary>
        /// <param name="hours">Часы</param>
        /// <param name="minutes">Минуты</param>
        /// <param name="seconds">Секунды</param>
        public void Change(int hours, int minutes, int seconds)
        {
            DateTime dt = new DateTime(2001, 9, 11, Hour, Minute, Second);

            dt = dt.AddHours(hours);
            dt = dt.AddMinutes(minutes);
            dt = dt.AddSeconds(seconds);

            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
    }
}
