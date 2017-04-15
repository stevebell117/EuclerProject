using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        //Prompt:
        //A palindromic number reads the same both ways.
        //The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

        //Find the largest palindrome made from the product of two 3-digit numbers.
        static void Main(string[] args)
        {
            int longestPalindrome = 0;
            int firstValue = 999, secondValue = 100;
            int divisible = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while(firstValue >= 100)
            {
                if (firstValue % 11 == 0)
                {
                    secondValue = 999;
                    divisible = 1;
                }
                else
                {
                    secondValue = 990;
                    divisible = 11;
                }

                while(secondValue >= firstValue)
                {
                    if((firstValue * secondValue) <= longestPalindrome)
                    {
                        break;
                    }

                    string stringValue = Convert.ToString(firstValue * secondValue);

                    if (StringFunctions.ReverseString(stringValue) == stringValue)
                    {
                        longestPalindrome = firstValue * secondValue;
                    }

                    secondValue = secondValue - divisible;
                }

                firstValue--;
            }

            sw.Stop();
            
            //long result = 0;
            //for (int x = 999; x >= 100; x--)
            //{
            //    for (int y = 999; y >= 100; y--)
            //    {
            //        long num = x * y;
            //        if (num.ToString() == StringFunctions.ReverseString(num.ToString()))
            //        {
            //            if (result < num)
            //            {
            //                result = num;
            //            }
            //        }
            //    }
            //}

            Console.WriteLine("Result: {0}", longestPalindrome);
            Console.WriteLine("Time in Milliseconds: {0}", sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static class StringFunctions
        {
            public static string ReverseString(string s)
            {
                string result = "";
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    result += s.Substring(i, 1);
                }
                return result;
            }
        }
    }
}
