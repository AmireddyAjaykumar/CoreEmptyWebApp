using CoreWebEmptyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebEmptyApp.Services
{
    public class PrimeFactorService : IPrimeFactor
    {
        public List<int> GetPrimeFactors(int num)
        {
            List<int> primeFactorsList = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                while(num % i == 0)
                {
                    primeFactorsList.Add(i);
                    num = num / i;
                }
            }
            return primeFactorsList;
        }
    }
}
