using _188204__BT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace _188204__BT2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DetailView()
        {
            return View();
        }
        public List<ProductListModel> GetProductList()
        {
            List<ProductListModel> productList = new List<ProductListModel>()
            {
                new ProductListModel { ProductID=1,Name="Đồ chơi Duka đồ chơi lúc lắc cho trẻ - chuông con thỏ - DK580009 ",Image="/Images/1.jpg",Price=629000,Discount=25,},
                new ProductListModel { ProductID=2,Name="Đồ chơi Duka đồ chơi lúc lắc cho trẻ - chuông nhỏ - DK580010",Image="/Images/2.jpg",Price=799000,Discount=20,},
                new ProductListModel { ProductID=3,Name="Đồ chơi lúc lắc cho trẻ - Chuông bàn tay bé Duka DK580006 - Màu ngẫu nhiên",Image="/Images/3.jpg",Price=1399000,Discount=20,},
                new ProductListModel { ProductID=4,Name="Đồ chơi trẻ em: Lắp ráp xe cứu hỏa & cảnh sát truy bắt tội phạm Lego 60319 (295 chi tiết) - Màu ngẫu nhiên",Image="/Images/4.jpg",Price=649000,Discount=20,},
                new ProductListModel { ProductID=5,Name="Đồ chơi phụ kiện móc khóa cún cưng Lego Dost 41927 (84 chi tiết)",Image="/Images/5.jpg",Price=869000,Discount=20,},
                new ProductListModel { ProductID=6,Name="Đồ chơi bể cá thần kì Lego Creator 31122 (325 chi tiết)",Image="/Images/1.jpg",Price=899000,Discount=20,},
            };
            return productList;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<SearchModels> GetSearchListProduct()
        {
            var searchProduct = new List<SearchModels>() { };
            foreach (var item in GetProductList())
            {
                searchProduct.Add(new SearchModels
                {
                    ProductID = item.ProductID,
                    Name = $"{item.Name}",
                    Image = $"{item.Image}",
                    Pricecurrent = $"{item.Calcula()}",
                    Priceold = $"{item.FormatPrice()}",
                    Discount = item.Discount,
                });
            }
            return searchProduct;
        }



        public JsonResult Search(string searchkeyWork)
        {

            var value = string.Empty;

            if (searchkeyWork != null)
            {
                List<SearchModels> product = GetSearchListProduct().Where(x => x.Name.ToLower().Contains(searchkeyWork.ToLower())).ToList();
                var kq = from itme in GetSearchListProduct()
                         where itme.Name.ToLower().Contains(searchkeyWork.ToLower())
                         select itme;
                value = JsonConvert.SerializeObject(kq, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                return Json(value);
            }
            return Json(value);


        }
    }
}
