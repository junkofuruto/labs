using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var43dll
{
    public class Star
    {
        int stopsCount;
        int lifeCount;
        double stopsDist;

        public int StopsCount
        {
            get { return stopsCount; }
            set { stopsCount = value; }
        }

        public int LifeCount
        {
            get { return lifeCount; }
            set { lifeCount = value; }
        }

        public double StopsDist
        {
            get { return stopsDist; }
            set { stopsDist = value; }
        }

        public double GetLiveProcent()
        {
            return Math.Round((double)lifeCount / (double)stopsCount, 2) * 100.0;
        }

        public double GetDistance()
        {
            return stopsCount * stopsDist;
        }

        public double GetTime(double speed)
        {
            return Math.Round(GetDistance() / speed, 2);
        }
    }
}
