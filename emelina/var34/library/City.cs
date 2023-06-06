using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLib
{
    public class City
    {
        string city_name;
        double square, living_cost;
        int population, attr_count;

        public string CityName
        {
            get
            {
                return city_name;
            }
            set
            {
                city_name = value;
            }
        }
        public double Square
        {
            get
            {
                return square;
            }
            set
            {
                if (value > 0)
                {
                    square = value;
                }
                else
                {
                    throw new Exception("Площадь должна быть положительной");
                }
                    
            }
        }
        public double LivingCost
        {
            get
            {
                return living_cost;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Цена проживания должна быть положительной");
                }
                else
                {
                    living_cost = value;
                }
            }
        }
        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Количество жителей дожно быть положительным");
                }
                else
                {
                    population = value;
                }
            }
        }
        public int AttrCount
        {
            get
            {
                return attr_count;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Количество жителей дожно быть положительным");
                }
                else
                {
                    attr_count = value;
                }
            }
        }

        public double PopulationDensity()
        {
            return Population / Square;
        }
        public int VisitLenght(int attrPerDay)
        {
            return AttrCount / attrPerDay;
        }
        public double CityRating()
        {
            double AttrRating, CostRating;

            if (AttrCount < 2) { AttrRating = 1; }
            else if (AttrCount >= 2 & AttrCount < 4) { AttrRating = 2; }
            else if (AttrCount >= 4 & AttrCount < 6) { AttrRating = 3; }
            else if (AttrCount >= 6 & AttrCount < 8) { AttrRating = 4; }
            else { AttrRating = 5; }

            if (LivingCost >= 1000) { CostRating = 1; }
            else if (LivingCost >= 8000 & LivingCost < 10000) { CostRating = 2; }
            else if (LivingCost >= 6000 & LivingCost < 8000) { CostRating = 3; }
            else if (LivingCost >= 4000 & LivingCost < 6000) { CostRating = 4; }
            else { CostRating = 5; }

            return (AttrRating + CostRating) / 2;
        }
        public virtual string GetInfo()
        {
            return $"Название: {CityName}\n" +
                   $"Площадь: {Square}\n" +
                   $"Цена проживания: {LivingCost}\n" +
                   $"Кол-во насиления: {Population}\n" +
                   $"Кол-во дост-ей: {AttrCount}\n" +
                   $"Рейтинг: {CityRating()}\n";
        }
    }

    public class Capital : City
    {
        string main_square;

        public string MainSquare
        {
            get
            {
                return main_square;
            }
            set
            {
                main_square = value;
            }
        }

        public override string GetInfo()
        {
            return $"Название: {CityName}\n" +
                   $"Площадь: {Square}\n" +
                   $"Цена проживания: {LivingCost}\n" +
                   $"Кол-во насиления: {Population}\n" +
                   $"Кол-во дост-ей: {AttrCount}\n" +
                   $"Рейтинг: {CityRating()}\n" +
                   $"Главная площадь: {MainSquare}\n";
        }
    }

    public class Underground : City
    {
        int levels_count;

        public int LevelsCount
        {
            get
            {
                return levels_count;
            }
            set
            {
                levels_count = value;
            }
        }

        public void AddLevel()
        {
            LevelsCount += 1;
        }
        public override string GetInfo()
        {
            return $"Название: {CityName}\n" +
                   $"Площадь: {Square}\n" +
                   $"Цена проживания: {LivingCost}\n" +
                   $"Кол-во насиления: {Population}\n" +
                   $"Кол-во дост-ей: {AttrCount}\n" +
                   $"Рейтинг: {CityRating()}\n" +
                   $"Количество уровней: {LevelsCount}\n";
        }
    }
}
