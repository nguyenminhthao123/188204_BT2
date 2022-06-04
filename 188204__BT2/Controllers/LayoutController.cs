using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _188204__BT2.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Header()
        {
            return View();
        }
        public IActionResult Footer()
        {
            return View();
        }
        
        public IActionResult Commit()
        {
            return View();
        }
    }
}
