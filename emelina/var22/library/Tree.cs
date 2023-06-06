using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll22
{
    public class Tree
    {
        protected Random random = new Random();

        protected int hitsToChop;
        protected int totalHitsToChop;
        protected int applesCount;

        public string Name;
        public int HitsToChop
        {
            get 
            {
                return hitsToChop;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Число ударов для рубки должно быть больше 0");
                }
                else
                {
                    totalHitsToChop = hitsToChop = value;
                }
            }
        }
        public int ApplesCount
        {
            get
            {
                return applesCount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Количество яблок не может быть меньше 0");
                }
                else
                {
                    applesCount = value;
                }
            }
        }
        public int TotalHitsToChop
        {
            get
            {
                return totalHitsToChop;
            }
        }

        public bool Chop()
        {
            if (totalHitsToChop > 1)
            {
                totalHitsToChop--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Shake()
        {
            int count = random.Next(0, applesCount + 1);
            applesCount -= count;
            if (applesCount == 0)
            {
                return false;
            }
            else
            {
                return true;
            }    
        }
        public string Type()
        {
            if (hitsToChop < 20) return "Слабое";
            else if (hitsToChop >= 20 & hitsToChop <= 50) return "Обычное";
            else return "Древнее";
        }
        public virtual void Heal()
        {
            totalHitsToChop += Convert.ToInt32(totalHitsToChop * (random.Next(10, 51) / 100.0));
            applesCount += Convert.ToInt32(applesCount * (random.Next(10, 51) / 100.0));
        }
        public virtual string Info()
        {
            return $"Название: {Name}\nУдаров, чтобы срубить: {HitsToChop}\nУдаров осталось: {ApplesCount}\nКоличество плодов: {TotalHitsToChop}\nТип: {Type()}\n\n";
        }
    }
    public class Exotic : Tree
    {
        public string Country;
        public override void Heal()
        {
            totalHitsToChop += Convert.ToInt32(totalHitsToChop * (random.Next(10, 51) / 100.0));
            applesCount += Convert.ToInt32(applesCount * (random.Next(5, 16) / 100.0));
        }
        public override string Info()
        {
            return $"Название: {Name}\nУдаров, чтобы срубить: {HitsToChop}\nУдаров осталось: {ApplesCount}\nКоличество плодов: {TotalHitsToChop}\nСтрана: {Country}\nТип: {Type()}\n\n";
        }
    }
    public class Enchanted : Tree
    {
        protected int enchantDays;
        public int EnchantDays
        {
            get
            {
                return enchantDays;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Число дней зачарования не может быть меньше 0");
                }
                else
                {
                    enchantDays = value;
                }
            }
        }

        public void RemoveEnchant()
        {
            enchantDays = 0;
        }
        public override void Heal()
        {
            totalHitsToChop += Convert.ToInt32(totalHitsToChop * (random.Next(10, 51) / 100.0));
            applesCount += Convert.ToInt32(applesCount * (random.Next(30, 71) / 100.0));
        }
        public override string Info()
        {
            return $"Название: {Name}\nУдаров, чтобы срубить: {HitsToChop}\nУдаров осталось: {ApplesCount}\nКоличество плодов: {TotalHitsToChop}\nДней зачарования: {EnchantDays}\nТип: {Type()}\n\n";
        }
    }
}
