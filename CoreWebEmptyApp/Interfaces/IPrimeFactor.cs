using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebEmptyApp.Interfaces
{
    public interface IPrimeFactor
    {
        List<int> GetPrimeFactors(int num);
    }
}
