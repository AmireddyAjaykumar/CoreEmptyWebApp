using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebEmptyApp.Controllers
{
    public class MvcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}