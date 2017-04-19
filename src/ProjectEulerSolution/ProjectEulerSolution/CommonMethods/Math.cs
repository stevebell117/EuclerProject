using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.CommonMethods
{
    public static class Math
    {
        public static int GreatestCommonFactor(int first, int second)
        {
            while (second != 0)
            {
                int temp = second;
                second = first % second;
                first = temp;
            }

            return first;
        }

        public static int LeastCommonMultiple(int first, int second)
        {
            int value = (first / GreatestCommonFactor(first, second)) * second;

            return value;
        }
    }
}
