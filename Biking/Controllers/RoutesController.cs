using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Biking.Controllers
{
    public class RoutesController : Controller
    {
        public IActionResult ShakopeeLoop()
        {
            return View();
        }
    }
}