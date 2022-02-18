using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continuous
{
    public class WorkingMethod
    {
        public static double CheckCompoundInterest(double a, double b, double c)
        {
            if (a < 10)
            {
                throw new ArgumentOutOfRangeException("Minimum amount money to make deposit");
            }

            if (b < 1)
            {
                throw new ArgumentOutOfRangeException("One year is the least number of years");
            }

            if (c < 0.01)
            {
                throw new ArgumentOutOfRangeException("Interest cannot be below 0.01");
            }

            if (c > 1)
            {
                throw new ArgumentOutOfRangeException("Interest cannot be above 1");
            }
            double interest = a * (b + c);
            return interest;
        }
    }
}
