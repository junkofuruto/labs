using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace EX1
{
    internal class Address : object
    {
        private int _index;
        private string _title;
        private string _city;

        /// <summary>
        /// Конструктор, принимающий адрес в строковом виде
        /// </summary>
        /// <param name="value"></param>
        public Address(string value)
        {
            string[] data = value.Split(',');

            Index = Convert.ToInt32(data[0]);
            City = data[1];
            Title = data[2];
        }

        /// <summary>
        /// Свойство, возвращающее значение почтового индекса адреса
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new Exception("Некорректное значение индекса");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее наименование компании
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (Regex.IsMatch(value, @"^[А-Я][A-Я][А-Я] .+$") == false)
                {
                    throw new Exception("Некорректное значение названия организации");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее наименование города
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (Regex.IsMatch(value, @"^\w+$") == false)
                {
                    throw new Exception("Некорректное название города");
                }
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает полный адрес в строковом виде
        /// </summary>
        public override string ToString()
        {
            return $"{Index}, {City}, {Title}";
        }
    }
}
