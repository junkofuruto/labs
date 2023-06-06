using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org_dll
{
    public class OrganismClass
    {
        double volume;
        double weight;

        public string Name;
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                try
                {
                    volume = 1 / Convert.ToInt32(!(value <= 0));
                    volume = value;
                }
                catch
                {
                    throw new Exception("Объем не может быть меньше, либо равен нулю.");
                }
            }
        } // > 0
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                try
                {
                    weight = 1 / Convert.ToInt32(!(value <= 0));
                    weight = value;
                }
                catch
                {
                    throw new Exception("Вес не может быть меньше, либо равен нулю.");
                }
            }
        } // > 0

        public void Rename(string name)
        {
            Name = name;
        }
        public void SetWeightByPercent(double percent)
        {
            Weight += Weight * (percent / 100);
        }
        public double GetDensity()
        {
            return Weight / Volume;
        }
        public string GetType()
        {
            if (GetDensity() > 10)
            {
                return "Низкая";
            }   
            else if (GetDensity() >= 10 & GetDensity() < 20)
            {
                return "Малая";
            }
            else if (GetDensity() >= 20 & GetDensity() < 30)
            {
                return "Средняя";
            }
            else if (GetDensity() >= 30 & GetDensity() < 40)
            {
                return "Высокая";
            }
            else
            {
                return "Сверхплотная";
            }
        }
        public virtual string Information()
        {
            string info = $"Имя: {Name}\n" +
                          $"Объем: {Volume}\n" +
                          $"Вес: {Weight}\n" +
                          $"Тип: {GetType()}\n" +
                          $"Плотность: {GetDensity()}\n\n";

            return info;
        }
    }

    public class UnicellularClass : OrganismClass
    {
        public bool HasMind;

        public override string Information()
        {
            string info = $"Имя: {Name}\n" +
                          $"Объем: {Volume}\n" +
                          $"Вес: {Weight}\n" +
                          $"Тип: {GetType()}\n" +
                          $"Плотность: {GetDensity()}\n" +
                          $"Разум: {HasMind}\n\n";

            return info;
        }
    }

    public class MulticellularClass : OrganismClass
    {
        int maxAge;

        public int MaxAge
        {
            get
            {
                return maxAge;
            }
            set
            {
                if (value > 0)
                {
                    maxAge = value;
                }
                else
                {
                    throw new Exception("Максимальный возраст должен быть больше нуля");
                }
            }
        } // > 0

        public override string Information()
        {
            string info = $"Имя: {Name}\n" +
                          $"Объем: {Volume}\n" +
                          $"Вес: {Weight}\n" +
                          $"Тип: {GetType()}\n" +
                          $"Плотность: {GetDensity()}\n\n";

            return info;
        }
    }
}
