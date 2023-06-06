using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib3_dll
{
    public class MessageClass
    {
        string message;

        public int SymbolCount;
        public int IndSymbolCount;
        public int Importance;
        public string Message
        {
            get { return message; }
            set 
            {
                message = value;
                IndSymbolCount = message.ToCharArray().Distinct().ToArray().Length;
                SymbolCount = message.Length;
            }
        }

        public double BitsInMessage()
        {
            return Math.Ceiling(Math.Log(IndSymbolCount, 2) + 1);
        }
        public int BytesInMessage()
        {
            return Convert.ToInt32(Math.Ceiling(SymbolCount * BitsInMessage() / 8));
        }
        public virtual string GetInfo()
        {
            return $"СООБЩЕНИЕ: {Message} \n" +
                   $"КОЛ-ВО СИМВОЛОВ: {SymbolCount} \n" +
                   $"КОЛ-ВО ИНДИВИДУАЛЬНЫХ СИМВОЛОВ: {IndSymbolCount} \n";
        }
    }

    public class WordClass : MessageClass
    {
        public string Synonym;

        public override string GetInfo()
        {
            return $"СООБЩЕНИЕ: {Message} \n" +
                   $"КОЛ-ВО СИМВОЛОВ: {SymbolCount} \n" +
                   $"КОЛ-ВО ИНДИВИДУАЛЬНЫХ СИМВОЛОВ: {IndSymbolCount} \n" +
                   $"СИНОНИМ: {Synonym}\n";
        }
    }

    public class SecretClass : MessageClass
    {
        public int SecretLevel = 0;

        public override string GetInfo()
        {
            return $"СООБЩЕНИЕ: {Message} \n" +
                   $"КОЛ-ВО СИМВОЛОВ: {SymbolCount} \n" +
                   $"КОЛ-ВО ИНДИВИДУАЛЬНЫХ СИМВОЛОВ: {IndSymbolCount} \n" +
                   $"УРОВЕНЬ СЕКРЕТНОСТИ: {SecretLevel}\n";
        }
    }
}