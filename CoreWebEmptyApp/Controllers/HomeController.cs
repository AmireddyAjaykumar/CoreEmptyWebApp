using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebEmptyApp.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebEmptyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IPrimeFactor primeFactor;

        public HomeController(IPrimeFactor primeFactor)
        {
            this.primeFactor = primeFactor;
        }

        [HttpGet("{Num}")]
        public async Task<List<int>> GetPrimeFactor(int Num)
        {           
            return await Task.FromResult(this.primeFactor.GetPrimeFactors(Num));
        }

        private List<int> PrimeFactor(int num)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    list.Add(i);
                    num = num / i;
                }
            }
            return list;
        }
    }
}