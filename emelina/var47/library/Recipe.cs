using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab47dll
{
    public class Recipe
    {
        double timeToCook;

        public double[] Weight = new double[3];
        public string[] Names = new string[3];
        public string KitchenType;
        public double TimeToCook
        {
            get { return timeToCook; }
            set 
            { 
                if (value <= 0)
                {
                    throw new Exception($"Ошибка! Время приготовления не может быть меньше нуля ({value})");
                }
                else
                {
                    timeToCook = value;
                }
            }
        }

        public void ChangeWeight1(double weight)
        {
            Weight[1] *= weight / Weight[0];
            Weight[2] *= weight / Weight[0];
            Weight[0] = weight;
        }
        public void ChangeWeight2(double weight)
        {
            Weight[0] *= weight / Weight[1];
            Weight[2] *= weight / Weight[1];
            Weight[1] = weight;
        }
        public void ChangeWeight3(double weight)
        {
            Weight[0] *= weight / Weight[2];
            Weight[1] *= weight / Weight[2];
            Weight[2] = weight;
        }
        public double FullWeigth()
        {
            return Weight[0] + Weight[1] + Weight[2];
        }
        public virtual string GetRecipeInfo()
        {
            return $"Вес 1-го ингр.: {Weight[0]}\n" +
                   $"Вес 2-го ингр.: {Weight[1]}\n" +
                   $"Вес 3-го ингр.: {Weight[2]}\n" +
                   $"Имя 1-го ингр.: {Names[0]}\n" +
                   $"Имя 2-го ингр.: {Names[1]}\n" +
                   $"Имя 3-го ингр.: {Names[2]}\n" +
                   $"Полный вес: {FullWeigth()}\n" +
                   $"Имя наибольшего: {GetHighestName()}\n" +
                   $"Время приготовления: {TimeToCook}\n\n\n";
        }
        public string GetHighestName()
        {
            return Names[Array.IndexOf(Weight, Weight.Max())];
        }
    }
    public class BakeryRecipe : Recipe
    {
        double tempToCook;
        public double TempToCook
        {
            get { return tempToCook; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Ошибка! Температура приготовления не может быть меньше нуля ({value})");
                }
                else
                {
                    tempToCook = value;
                }
            }
        }

        public override string GetRecipeInfo()
        {
            return $"Вес 1-го ингр.: {Weight[0]}\n" +
                   $"Вес 2-го ингр.: {Weight[1]}\n" +
                   $"Вес 3-го ингр.: {Weight[2]}\n" +
                   $"Имя 1-го ингр.: {Names[0]}\n" +
                   $"Имя 2-го ингр.: {Names[1]}\n" +
                   $"Имя 3-го ингр.: {Names[2]}\n" +
                   $"Полный вес: {FullWeigth()}\n" +
                   $"Имя наибольшего: {GetHighestName()}\n" +
                   $"Темп. приготовления: {TimeToCook}\n\n\n";
        }
    }
    public class JamRecipe : Recipe
    {
        double timeToBoil;
        public double TimeToBoil
        {
            get { return timeToBoil; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception($"Ошибка! Время варки не может быть меньше нуля ({value})");
                }
                else
                {
                    timeToBoil = value;
                }
            }
        }

        public override string GetRecipeInfo()
        {
            return $"Вес 1-го ингр.: {Weight[0]}\n" +
                   $"Вес 2-го ингр.: {Weight[1]}\n" +
                   $"Вес 3-го ингр.: {Weight[2]}\n" +
                   $"Имя 1-го ингр.: {Names[0]}\n" +
                   $"Имя 2-го ингр.: {Names[1]}\n" +
                   $"Имя 3-го ингр.: {Names[2]}\n" +
                   $"Полный вес: {FullWeigth()}\n" +
                   $"Имя наибольшего: {GetHighestName()}\n" +
                   $"Время варки: {TimeToBoil}\n\n\n";
        }
    }
}
