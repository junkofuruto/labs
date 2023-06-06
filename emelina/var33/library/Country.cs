using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Country
    {
        double square;
        double population;
        double yearBudget;

        public string Relief;
        public string CountryName;
        public double Square
        {
            get { return square; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    square = value;
                }
            }
        }
        public double Population
        {
            get { return population; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    population = value;
                }
            }
        }
        public double YearBudget
        {
            get { return yearBudget; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    yearBudget = value;
                }
            }
        }

        public string CountryType()
        {
            if (YearBudget / Population < 50000)
            {
                return "Бедная";
            }
            else if (YearBudget / Population > 50000 & YearBudget / Population < 500000)
            {
                return "Среднеобеспеченная";
            }
            else
            {
                return "Богатая";
            }
        }
        public double Dencity()
        {
            return Population / Square;
        }
        public double PersonSquare()
        {
            return Square / Population;
        }
        public void DoWar(double warSquare, double warPopulation)
        {
            Square += warSquare;
            Population += warPopulation;
        }
        public virtual string GetInfo()
        {
            return $"Обычная страна: {CountryName}\n" +
                   $"Площадь: {Square}\n" +
                   $"Рельеф: {Relief}\n" +
                   $"Население: {Population}\n" +
                   $"Тип: {CountryType()}\n" +
                   $"Число человек на 1 КМ: {Dencity()}\n" +
                   $"КМ на 1 человека: {PersonSquare()}\n\n";
        }
    }
    public class Monarchy : Country
    {
        public string KingName;
        public int FromWharYear;
        public override string GetInfo()
        {
            return $"Королевство: {CountryName}\n" +
                   $"Площадь: {Square}\n" +
                   $"Рельеф: {Relief}\n" +
                   $"Население: {Population}\n" +
                   $"Тип: {CountryType()}\n" +
                   $"Имя короля: {KingName}\n" +
                   $"Правит с: {FromWharYear}\n" +
                   $"Число человек на 1 КМ: {Dencity()}\n" +
                   $"КМ на 1 человека: {PersonSquare()}\n\n";
        }
    }
    public class Republic : Country
    {
        public string PresidentName;
        public void ChoosePresident(string newPresident)
        {
            PresidentName = newPresident;
        }
        public override string GetInfo()
        {
            return $"Республика: {CountryName}\n" +
                   $"Площадь: {Square}\n" +
                   $"Рельеф: {Relief}\n" +
                   $"Население: {Population}\n" +
                   $"Тип: {CountryType()}\n" +
                   $"Имя президента: {PresidentName}\n" +
                   $"Число человек на 1 КМ: {Dencity()}\n" +
                   $"КМ на 1 человека: {PersonSquare()}\n\n";
        }
    }
}
