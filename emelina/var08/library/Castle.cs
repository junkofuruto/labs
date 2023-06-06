using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleLib
{
    public class CastleClass
    {
        public string CastleName;
        public double CastleMoney;
        public double CastleEarnings;
        public double CastleExpenses;

        public void NextDay()
        {
            CastleMoney += CastleEarnings;
            CastleMoney -= CastleExpenses;
        }

        public void RobCastle(double amount)
        {
            CastleEarnings += amount;
        }

        public void GetRobbed(double amount)
        {
            CastleExpenses += amount;
        }
    }
}
