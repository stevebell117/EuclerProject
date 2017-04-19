using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.ProblemClasses
{
    class SumSquareDifference
    {
        /// <summary>
        /// Get the Difference between a Sum of Squares and a Square of Sums.
        /// <para>The value entered will be the ceiling; </para>
        /// <para>Example: If 100 entered, will be the Sum of Squares up to 100.</para>
        /// </summary>
        /// <param name="valueToGetSumSquareDifference"></param>
        /// <returns></returns>
        public long GetSumSquareDifference(int valueToGetSumSquareDifference)
        {
            long sumOfSquares = 0;
            int squareOfSumsInt = 0;

            for(int i = 1; i <= valueToGetSumSquareDifference; i++)
            {
                sumOfSquares += Math.BigMul(i, i);
            }

            for(int i = 1; i <= valueToGetSumSquareDifference; i++)
            {
                squareOfSumsInt += i;
            }

            long squareOfSumsLong = Math.BigMul(squareOfSumsInt, squareOfSumsInt);

            return squareOfSumsLong - sumOfSquares;
        }
    }
}
