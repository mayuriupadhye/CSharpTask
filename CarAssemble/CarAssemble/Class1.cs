using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssemble
{
    class Class1
    {
        public static int hr = 221;
        public double SuccessRate(int speed)
        {
            if (speed >= 1 && speed <= 4)
            {
                return 1.0;
            }
            if (speed >= 5 && speed <= 8)
            {
                return 0.9;
            }
            if (speed <= 9)
            {
                return 0.8;
            }
            if (speed == 10)
            {
                return 0.77;
            }
            return speed;

        }
        public double ProductionRatePerHr(int speed)
        {
            return hr * speed * SuccessRate(speed);
        }
        public int WorkingItemsPerMin(int speed)
        {
            return (int)ProductionRatePerHr(speed) / 60;
        }

    }
}
