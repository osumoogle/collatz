using System.Collections.Generic;

namespace HailNumber
{
    public class HailCalculator
    {
        public static HailNumber CalculateHailNumber(long number)
        {
            var hail = new HailNumber(number);
            while (number > 1)
            {
                if (number % 2 == 0)
                    number /= 2;
                else
                    number = number * 3 + 1;

                hail.Value++;
                hail.Hops.Add(number);
            }

            return hail;
        }
    }
}
