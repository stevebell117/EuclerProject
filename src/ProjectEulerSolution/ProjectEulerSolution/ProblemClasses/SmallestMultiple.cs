using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.ProblemClasses
{
    class SmallestMultiple
    {
        /// <summary>
        /// Input value list for Smallest multiple of a set of values.
        /// <para>example 1,2,3,4,5 would be CalculateSmallestMultiple(1,5)</para>
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="lastValue"></param>
        /// <returns></returns>
        public int CalculateSmallestMultiple(int firstValue, int lastValue)
        {
            int finalAnswer = IterativeSmallestMultiple(firstValue, firstValue + 1);

            for(int i = firstValue + 2; i < lastValue; i++)
            {
                finalAnswer = IterativeSmallestMultiple(finalAnswer, i);
            }

            return finalAnswer;
        }
        
        private int IterativeSmallestMultiple(int firstValue, int secondValue)
        {
            return CommonMethods.Math.LeastCommonMultiple(firstValue, secondValue);
        }
    }
}
