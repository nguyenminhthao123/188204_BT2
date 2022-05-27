using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _188204__BT2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult DetailView()
        {
            return View();
        }
    }
}
