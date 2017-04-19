using ProjectEuler.ProblemClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            #region Smallest Multiple
            sw.Start();
            SmallestMultiple a = new SmallestMultiple();
            Console.WriteLine("Smallest Multiple: " + a.CalculateSmallestMultiple(1, 20));
            sw.Stop();
            Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds);
            #endregion

            #region Sum Square Difference
            sw.Reset();
            sw.Start();
            SumSquareDifference b = new SumSquareDifference();
            Console.WriteLine("Sum Square Difference: " + b.GetSumSquareDifference(100));
            sw.Stop();
            Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds);

            #endregion

            #region 10001st Prime Number

            sw.Reset();
            sw.Start();
            TenThousandOnePrime c = new TenThousandOnePrime();
            Console.WriteLine("Ten Thousand One Prime: " + c.GetPrime(10001));
            sw.Stop();
            Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds);

            #endregion

            Console.ReadKey();
        }
    }
}
