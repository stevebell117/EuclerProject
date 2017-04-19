using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.ProblemClasses
{
    class TenThousandOnePrime
    {
        public int GetPrime(int primeCeiling)
        {
            int valueToReturn = 0;
            int primeCount = 1;
            List<int> listOfPrimes = new List<int> { 2 };

            for (int i = 2; primeCount < primeCeiling; i++)
            {
                if(isPrime(i, listOfPrimes))
                {
                    valueToReturn = i;
                    primeCount++;
                }
            }

            return valueToReturn;
        }

        private bool isPrime(int value, List<int> existingPrimes)
        {
            foreach(int prime in existingPrimes)
            {
                if(value % prime == 0)
                {
                    return false;
                }
            }

            if (existingPrimes.Contains(value) == false) { existingPrimes.Add(value); }
            return true;
        }
    }
}
