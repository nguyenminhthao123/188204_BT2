using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _188204__BT2.Models;

namespace _188204__BT2.Components
{
    [ViewComponent]
    public class ProductItem : ViewComponent
    {
        public IViewComponentResult Invoke(ProductListModel product)
        {
            return View("productItem", product);
        }
    }
}
