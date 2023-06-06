using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6dll
{
    public class Artifact
    {
        protected int ExceptionBlank;                 // ПЕРЕМЕННАЯ ДЛЯ ПРОВЕРКИ УСЛОВИЙ (ДЕЛЕНИЕ int ЧИСЕЛ НА 0 ЗАПРЕЩЕНО)

        public string ArtifactName;         // НАЗВАНИЕ АРТ.
        public double ArtifactPrice;        // ЦЕНА АРТ.
        public double DamageIncrease;       // ПРИРОСТ УРОНА (%)
        public double HealthIncrease;       // ПРИРОСТ ЗДОРОВЬЯ (%)
        public double DefenceIncrease;      // ПРИРОСТ ЗАЩИТЫ (%)
        public double Discount;             // СКИДКА
        
        public double GetIncreasedDamage(double damage)
        {
            try
            {
                ExceptionBlank = 1 / Convert.ToInt32(0 <= damage);

                return damage + damage * (DamageIncrease / 100);
            }
            catch { throw new Exception("[!] УРОН НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 0"); }
        }
        public double GetIncreasedHealth(double health)
        {
            try
            {
                ExceptionBlank = 1 / Convert.ToInt32(0 <= health);

                return health + health * (HealthIncrease / 100);
            }
            catch { throw new Exception("[!] ЗДОРОВЬЕ НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 0"); }
        }
        public double GetIncreasedDefence(double defence)
        {
            try
            {
                ExceptionBlank = 1 / Convert.ToInt32(0 <= defence);

                return defence + defence * (DefenceIncrease / 100);
            }
            catch { throw new Exception("[!] ЗАЩИТА НЕ МОЖЕТ БЫТЬ МЕНЬШЕ 0"); }
        }
        public virtual double GetPriceWithDiscount(double discount)
        {
            try
            {
                ExceptionBlank = 1 / Convert.ToInt32(0 <= discount & discount <= 100);

                // НАМЕРЕННОЕ СОЗДАНИЕ ОШИБКИ: ЕСЛИ УСЛОВИЕ НЕ ВЫПОЛНЯЕТСЯ,
                // ТО ПРИ КОНВЕРТАЦИИ В int FALSE-ЗНАЧЕНИЕ СТАНЕТ НУЛЕМ,
                // А ДЕЛЕНИЕ int ЧИСЕЛ НА 0 ЗАПРЕЩЕНО

                return ArtifactPrice - ArtifactPrice * (discount / 100);
            }
            catch
            {
                throw new Exception("[!] СКИДКА НЕ МОЖЕТ БЫТЬ БОЛЬШЕ 100% И МЕНЬШЕ 0%");

                // ЕСЛИ ИСКЛЮЧЕНИЕ ОТРАБОТАЛО, ТО ВЫБРАСЫВАЕТСЯ ОШИБКА, КОТОРУЮ
                // МОЖНО БУДЕТ ОБРАБОТАТЬ В САМОМ ПРИЛОЖЕНИИ
            }
        }
        public string ArtifactType()
        {
            if (DamageIncrease < 0 & HealthIncrease < 0 & DefenceIncrease < 0)
            {
                return "Проклятый";
            }
            else if (DamageIncrease > 0 & HealthIncrease > 0 & DefenceIncrease > 0)
            {
                return "Суперартефакт";
            }
            else
            {
                return "Обычный";
            }
        }
        public virtual string GetInfo()
        {
            return $"Название артефакта {ArtifactName}\n" +
                   $"Цена артефакта {ArtifactPrice}\n" +
                   $"Прирост урона {DamageIncrease}\n" +
                   $"Прирост здоровья {HealthIncrease}\n" +
                   $"Прирост защиты {DefenceIncrease}\n" +
                   $"Тип {ArtifactType()}\n" +
                   $"Цена со скидкой {GetPriceWithDiscount(Discount)}\n" +
                   $"================================\n";
        }
    }

    public class Sword : Artifact
    {
        public string SwordName;
        public override double GetPriceWithDiscount(double discount)
        {
            try
            {
                ExceptionBlank = 1 / Convert.ToInt32(0 <= discount & discount <= 100);

                return ArtifactPrice - ArtifactPrice * (discount / 50);
            }
            catch
            {
                throw new Exception("[!] СКИДКА НЕ МОЖЕТ БЫТЬ БОЛЬШЕ 100% И МЕНЬШЕ 0%");
            }
        }
        public override string GetInfo()
        {
            return $"Название артефакта {ArtifactName}\n" +
                   $"Цена артефакта {ArtifactPrice}\n" +
                   $"Прирост урона {DamageIncrease}\n" +
                   $"Прирост здоровья {HealthIncrease}\n" +
                   $"Прирост защиты {DefenceIncrease}\n" +
                   $"Тип {ArtifactType()}\n" +
                   $"Цена со скидкой {GetPriceWithDiscount(Discount)}\n" +
                   $"Название меча {SwordName}\n" +
                   $"================================\n";
        }
        public void Harden()
        {
            DamageIncrease += DamageIncrease / 10;
        }
    }

    public class Ring : Artifact
    {
        public string RingMaterial;
        public override double GetPriceWithDiscount(double discount)
        {
            try
            {
                ExceptionBlank = 1 / Convert.ToInt32(0 <= discount & discount <= 100);

                return ArtifactPrice - ArtifactPrice * (discount / 10);
            }
            catch
            {
                throw new Exception("[!] СКИДКА НЕ МОЖЕТ БЫТЬ БОЛЬШЕ 100% И МЕНЬШЕ 0%");
            }
        }
        public override string GetInfo()
        {
            return $"Название артефакта {ArtifactName}\n" +
                   $"Цена артефакта {ArtifactPrice}\n" +
                   $"Прирост урона {DamageIncrease}\n" +
                   $"Прирост здоровья {HealthIncrease}\n" +
                   $"Прирост защиты {DefenceIncrease}\n" +
                   $"Тип {ArtifactType()}\n" +
                   $"Цена со скидкой {GetPriceWithDiscount(Discount)}\n" +
                   $"Материал {RingMaterial}\n" +
                   $"================================\n";
        }
    }
}
