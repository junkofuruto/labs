using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Alien
    {
        double minHeight, maxHeight, nowHeight;

        public string Name;
        public string Planet;
        public double MinHeight
        {
            get
            {
                return minHeight;
            }
            set
            {
                if (value > 0) minHeight = value;
                else throw new Exception("Минимальный рост должен быть больше 0");
            }
        }
        public double MaxHeight
        {
            get
            {
                return maxHeight;
            }
            set
            {
                if (value > 0) maxHeight = value;
                else throw new Exception("Максимальный рост должен быть больше 0");
            }
        }
        public double NowHeight
        {
            get
            {
                return nowHeight;
            }
            set
            {
                if (value > 0) nowHeight = value;
                else throw new Exception("Рост должен быть больше 0");
            }
        }

        public double Deviation()
        {
            return (MinHeight + MaxHeight) / 2;
        }
        public virtual string Info()
        {
            return $"Инопланетянин {Name} с планеты {Planet} ростом {NowHeight}\n" +
                   $"Мин. рост {MinHeight}\n" +
                   $"Макс. рост {MaxHeight}\n";
        }
        public void ChangeHeight(double height_dev)
        {
            NowHeight += height_dev;
        }
    }

    public class Humanoid : Alien
    {
        double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new Exception("Вес должен быть больше 0");
                }
            }
        }
        public override string Info()
        {
            return $"Гуманоид {Name} с планеты {Planet} ростом {NowHeight} и весом {Weight}\n" +
                   $"Мин. рост {MinHeight}\n" +
                   $"Макс. рост {MaxHeight}\n";
        }
    }

    public class Reptiloid : Alien
    {
        int tailCount;
        public int TailCount
        {
            get
            {
                return tailCount;
            }
            set
            {
                if (value >= 0)
                {
                    tailCount = value;
                }
                else
                {
                    throw new Exception("Количество хвостов не может быть отрицательным");
                }
            }
        }
        public override string Info()
        {
            return $"Рептилоид {Name} с планеты {Planet} ростом {NowHeight} и количеством ховстов {TailCount}\n" +
                   $"Мин. рост {MinHeight}\n" +
                   $"Макс. рост {MaxHeight}\n";
        }
    }
}
