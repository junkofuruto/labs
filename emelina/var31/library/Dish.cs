using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Dish
    {
        double dishWeight;
        double dishCalory;
        double dishPrice;

        public string DishName;
        public double DishWeight
        {
            get { return dishWeight; }
            set
            {
                try
                {
                    dishWeight = 1 / Convert.ToInt32(value >= 0);
                    dishWeight = value;
                }
                catch { throw new Exception("Вес не может быть меньше нуля"); }
            }
        }
        public double DishCalory 
        { 
            get { return dishCalory; }
            set
            {
                try
                {
                    dishCalory = 1 / Convert.ToInt32(value >= 0);
                    dishCalory = value;
                }
                catch { throw new Exception("Калорийность не может быть меньше нуля"); }
            }
        }
        public double DishPrice
        {
            get { return dishPrice; }
            set
            {
                try
                {
                    dishPrice = 1 / Convert.ToInt32(value >= 0);
                    dishPrice = value;
                }
                catch { throw new Exception("Цена не может быть меньше нуля"); }
            }
        }

        public void RecalcCalory(double weight)
        {
            dishCalory = dishCalory / dishWeight * weight;
            dishWeight = weight;
        }

        public void RecalcPrice(double weight)
        {
            dishPrice = dishPrice / dishWeight * weight;
            dishWeight = weight;
        }

        public double ReturnedWeight(double weight)
        {
            return 0.004 * weight;
        }
    }
}
