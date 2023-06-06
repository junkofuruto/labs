using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class NormalGame
    {
        uint lettersCount, lettersGuessed, possibleMistakes, totalMistakes;

        public uint LettersCount
        {
            get { return lettersCount; }
            set { lettersCount = value; }
        }   // Число букв
        public uint LettersGuessed
        {
            get { return lettersGuessed; }
            set { lettersGuessed = value; }
        } // Число отгаданных букв
        public uint TotalMistakes
        {
            get { return possibleMistakes; }
            set { possibleMistakes = value; }
        }  // Допустимое число ошибок
        public uint TakenMistakes
        {
            get { return totalMistakes; }
            set { totalMistakes = value; }
        }  // Сколько сделано в ошибок
        
        public virtual uint PossibleMistakes()
        {
            return TotalMistakes - TakenMistakes;
        }
        public string Risk()
        {
            if (PossibleMistakes() < 2)
            {
                return "Наивысший";
            }
            else if (PossibleMistakes() < 4)
            {
                return "Высокий";
            }
            else if (PossibleMistakes() < 6)
            {
                return "Средний";
            }
            else if (PossibleMistakes() < 8)
            {
                return "Малый";
            }
            else
            {
                return "Низкий";
            }

        }
        public double MistakesPercent(int movesCount)
        {
            return (double)TotalMistakes / movesCount;
        }
        public virtual string Inf()
        {
            return $"Число букв: {LettersCount}\n" +
                   $"Число отгаданных букв: {LettersGuessed}\n" +
                   $"Допустимое число ошибок: {TotalMistakes}\n" +
                   $"Сколько сделано в ошибок: {TakenMistakes}\n" +
                   $"Возможности на ошибку: {PossibleMistakes()}\n" +
                   $"Риск: {Risk()}\n";
        }
    }

    public class EasyGame : NormalGame
    {
        uint attempCount;
        bool used = false;

        public uint AttempCount
        {
            get { return attempCount; }
            set { attempCount = value; }
        }
        public override uint PossibleMistakes()
        {
            uint mist = TotalMistakes - TakenMistakes;
            
            if (mist != 1 & used == false)
            {
                return mist;
            }
            else
            {
                TakenMistakes -= AttempCount;
                return mist;
            }
        }
        public override string Inf()
        {
            return base.Inf() + $"Количество попыток: {AttempCount}\n";
        }
    }

    public class HardGame : NormalGame
    {
        bool isSkiped;
        
        public bool IsSkiped
        {
            get { return isSkiped; }
            set { isSkiped = value; }
        }
        public void Skip()
        {
            TakenMistakes++;
        }
        public override uint PossibleMistakes()
        {
            return TotalMistakes - TakenMistakes - Convert.ToUInt32(IsSkiped);
        }
        public override string Inf()
        {
            return base.Inf() + $"Пропущено: {IsSkiped}\n";
        }
    }
}
