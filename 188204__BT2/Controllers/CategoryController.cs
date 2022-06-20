using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _188204__BT2.Models;
using PagedList;

namespace _188204__BT2.Controllers
{
    public class CategoryController : Controller
    {

        public List<ProductListModel> GetProductList()
        {
            List<ProductListModel> productList = new List<ProductListModel>()
            {
                new ProductListModel { ProductID=1,Name="Tã quần Merries size L",Image="https://cdn.tgdd.vn/Products/Images/2427/273306/ta-quan-merries-size-l-56-mieng-9-14-kg-160622-014641-600x600.jpg",Price=430000,TypeCN=5,Type=3,Brand=1},
                new ProductListModel { ProductID=2,Name="Tã dán Moony Natural size L",Image="https://cdn.tgdd.vn/Products/Images/2427/230493/ta-dan-moony-natural-size-l-38-mieng-cho-be-9-14kg-160622-052922-600x600.jpg",Price=378000,Discount=15,TypeCN=5,Type=2,Brand=1},
                new ProductListModel { ProductID=3,Name="Tã quần Merries size L",Image="https://cdn.tgdd.vn/Products/Images/2427/81465/ta-quan-merries-size-l-44-mieng-cho-be-9-14kg-150622-060043-600x600.jpg",Price=370000,TypeCN=5,Type=3,Brand=1},
                new ProductListModel { ProductID=4,Name="Tã dán Merries size L",Image="https://cdn.tgdd.vn/Products/Images/2427/236049/ta-dan-merries-size-l-54-mieng-cho-be-9-14kg-160622-093644-600x600.jpg",Price=370000,TypeCN=5,Type=2,Brand=2},
                new ProductListModel { ProductID=5,Name="Tã quần Moony Natural man size L",Image="https://cdn.tgdd.vn/Products/Images/2427/230479/ta-quan-moony-natural-man-size-l-36-mieng-cho-be-9-14kg-160622-052632-600x600.jpg",Price=369700,Discount=15,TypeCN=5,Type=3,Brand=2},
                new ProductListModel { ProductID=6,Name="Tã dán Merries size NB",Image="https://cdn.tgdd.vn/Products/Images/2427/81478/ta-dan-merries-size-nb-90-mieng-duoi-5-kg-150622-060506-600x600.jpg",Price=370000,TypeCN=1,Type=2,Brand=3},
                new ProductListModel { ProductID=7,Name="Tã dán Moony Natural size NB",Image="https://cdn.tgdd.vn/Products/Images/2427/230481/ta-dan-moony-natural-newborn-63-mieng-cho-be-duoi-5kg-160622-052741-600x600.jpg",Price=356000,Discount=20,TypeCN=1,Type=2,Brand=3},
                new ProductListModel { ProductID=8,Name="Tã dán Moony size NB",Image="https://cdn.tgdd.vn/Products/Images/2427/196874/ta-dan-moony-size-nb-90-mieng-cho-be-duoi-5kg-160622-061607-600x600.jpg",Price=327200,Discount=15,TypeCN=1,Type=2,Brand=3},
                new ProductListModel { ProductID=9,Name="Tã quần Pampers size NB/S",Image="https://cdn.tgdd.vn/Products/Images/2427/241286/ta-quan-pampers-size-nb-s-52-mieng-cho-be-4-8kg-160622-013640-600x600.jpg",Price=229600,Discount=20,TypeCN=1,Type=3,Brand=4},
                new ProductListModel { ProductID=10,Name="Tã dán Huggies sơ sinh size NB",Image="https://cdn.tgdd.vn/Products/Images/2427/260213/ta-dan-huggies-so-sinh-size-nb-74-mieng-duoi-5-kg-160622-054600-600x600.jpg",Price=176400,Discount=10,TypeCN=1,Type=2,Brand=4},
                new ProductListModel { ProductID=11,Name="Tã dán Moony Natural size S",Image="https://cdn.tgdd.vn/Products/Images/2427/230492/ta-dan-moony-natural-size-s-58-mieng-cho-be-4-8kg-160622-052845-600x600.jpg",Price=378200,Discount=15,TypeCN=2,Type=2,Brand=5},
                new ProductListModel { ProductID=12,Name="Tã quần Bobby size S",Image="https://cdn.tgdd.vn/Products/Images/2427/259326/ta-quan-bobby-size-s-46-mieng-4-8-kg-160622-054021-600x600.jpg",Discount=15,Price=176800,TypeCN=2,Type=3,Brand=4},
                new ProductListModel { ProductID=13,Name="Tã dán sơ sinh IQ Baby size S3",Image="https://cdn.tgdd.vn/Products/Images/2427/259197/ta-dan-so-sinh-iqbaby-size-s3-2-cai-bich-cho-be-6-9-thang-mau-ngau-nhien-600x600.jpg",Price=31000,Discount=10,TypeCN=2,Type=2,Brand=5},
                new ProductListModel { ProductID=14,Name="Tã dán Pampers cao cấp size S",Image="https://cdn.tgdd.vn/Products/Images/2427/238793/ta-dan-pampers-cao-cap-size-s-64-mieng-cho-be-4-8kg-160622-113945-600x600.jpg",Price=368000,Discount=20,TypeCN=2,Type=2,Brand=5},
                new ProductListModel { ProductID=15,Name="Tã lót Bobby size NB1",Image="https://cdn.tgdd.vn/Products/Images/2427/196960/mieng-lot-so-sinh-bobby-size-nb1-108-mieng-cho-be-duoi-1-thang-600x600.png",Price=156000,Discount=15,TypeCN=1,Type=1,Brand=6},
                new ProductListModel { ProductID=16,Name="Tã lót Huggies Dry size NB1",Image="https://cdn.tgdd.vn/Products/Images/2427/193635/mieng-lot-so-sinh-huggies-dry-size-nb1-100-mieng-cho-be-duoi-5kg1.-600x600.png",Price=129000,Discount=10,TypeCN=1,Type=1,Brand=4},
                new ProductListModel { ProductID=17,Name="Tã quần Moony Natural man size M",Image="https://cdn.tgdd.vn/Products/Images/2427/230893/ta-quan-moony-natural-man-size-m-46-mieng-cho-be-5-10kg-160622-053238-600x600.jpg",Price=450000,Discount=15,TypeCN=3,Type=3,Brand=5},
                new ProductListModel { ProductID=18,Name="Tã dán Moony Natural size M",Image="https://cdn.tgdd.vn/Products/Images/2427/230494/ta-dan-moony-natural-size-m-46-mieng-cho-be-6-11kg-160622-053020-600x600.jpg",Discount=15,Price=445000,TypeCN=3,Type=2,Brand=2},
                new ProductListModel { ProductID=19,Name="Tã quần Pampers Super Jumbo size M",Image="https://cdn.tgdd.vn/Products/Images/2427/238816/ta-quan-pampers-super-jumbo-size-m-74-mieng-cho-be-7-12kg-160622-115416-600x600.jpg",Price=480000,Discount=30,TypeCN=3,Type=3,Brand=6},
                new ProductListModel { ProductID=20,Name="Tã dán Moony Natural size L",Image="https://cdn.tgdd.vn/Products/Images/2427/230493/ta-dan-moony-natural-size-l-38-mieng-cho-be-9-14kg-160622-052922-600x600.jpg",Price=378200,Discount=15,Type=2,TypeCN=4},
                new ProductListModel { ProductID=21,Name="Tã quần Moony Natural man size XL",Image="https://cdn.tgdd.vn/Products/Images/2427/230480/ta-quan-moony-natural-man-size-xl-32-mieng-cho-be-12-22kg-160622-052705-600x600.jpg",Price=445000,Discount=15,TypeCN=5,Type=3,Brand=7},
                new ProductListModel { ProductID=22,Name="Tã quần Moony man bé gái size XL",Image="https://cdn.tgdd.vn/Products/Images/2427/81488/ta-quan-moony-man-be-gai-size-xl-38-mieng-cho-be-12-22kg-160622-050842-600x600.jpg",Price=385000,Discount=15,TypeCN=5,Type=3,Brand=7},
                new ProductListModel { ProductID=23,Name="Tã quần Merries size XXL",Image="https://cdn.tgdd.vn/Products/Images/2427/260246/ta-quan-merries-size-xxl-26-mieng-15-28-kg-160622-014205-600x600.jpg",Price=435000,Discount=15,TypeCN=6,Type=3,Brand=7},
                new ProductListModel { ProductID=24,Name="Tã quần Huggies Dry size XXL",Image="https://cdn.tgdd.vn/Products/Images/2427/96135/ta-quan-huggies-dry-size-xxl-56-mieng-cho-be-tren-15kg-170622-044810-600x600.jpg",Price=380000,Discount=10,TypeCN=6,Type=3,Brand=7},
                new ProductListModel { ProductID=25,Name="Tã quần ban đêm Pampers ngủ ngon size XXL",Image="https://cdn.tgdd.vn/Products/Images/2427/261529/ta-quan-pampers-ngu-ngon-size-xxl-22-mieng-tu-15-25-kg-600x600.png",Price=185000,Discount=15,TypeCN=7,Type=3,Brand=6},
                new ProductListModel { ProductID=26,Name="Tã quần Bobby size XXL",Image="https://cdn.tgdd.vn/Products/Images/2427/77441/ta-quan-bobby-size-xxl-30-mieng-15-25-kg-160622-045711-600x600.jpg",Price=238000,Discount=15,TypeCN=7,Type=3,Brand=4},
                new ProductListModel { ProductID=27,Name="Tã dán sơ sinh IQ Baby size S2",Image="https://cdn.tgdd.vn/Products/Images/2427/259196/ta-dan-so-sinh-iqbaby-size-s2-2-cai-bich-mau-ngau-nhien-090122-011406-600x600.png",Price=41000,Discount=30,TypeCN=2,Type=2,Brand=3},
                new ProductListModel { ProductID=28,Name="Tã người lớn Caryn siêu thấm size L",Image="https://cdn.tgdd.vn/Products/Images/2427/91566/tam-dem-lot-caryn-loai-sieu-tham-size-l-10-mieng-310322-020633-600x600.jpg",Discount=5,Price=62000,TypeCN=4,Type=5,Brand=1},
                new ProductListModel { ProductID=29,Name="Tã người lớn Caryn siêu thấm size L",Image="https://cdn.tgdd.vn/Products/Images/2427/91566/tam-dem-lot-caryn-loai-sieu-tham-size-l-10-mieng-310322-020633-600x600.jpg",Discount=5,Price=62000,TypeCN=4,Type=5,Brand=1},
                new ProductListModel { ProductID=30,Name="Tã người lớn Caryn siêu thấm size L",Image="https://cdn.tgdd.vn/Products/Images/2427/91566/tam-dem-lot-caryn-loai-sieu-tham-size-l-10-mieng-310322-020633-600x600.jpg",Discount=5,Price=62000,TypeCN=4,Type=5,Brand=2},

            };
            return productList;
        }
        public List<CategoryList> GetCategoryLists()
        {
            var categoryList = new List<CategoryList>() { };
            foreach (var item in GetProductList())
            {
                categoryList.Add(new CategoryList
                {
                    ProductID = item.ProductID,
                    Name = $"{item.Name}",
                    Image = $"{item.Image}",
                    Pricecurrent = $"{item.Calcula()}",
                    Priceold = $"{item.FormatPrice()}",
                    Discount = item.Discount,
                    Price = item.Price,
                    TypeCN = item.TypeCN,
                    Type = item.Type,
                    Brand = item.Brand,
                });
            }
            return categoryList;

        }
        public IActionResult Category()
        {
            //var ProductList = GetCategoryLists();
            //if (page == null) page = 1;
            //var links = (from l in ProductList
            //             select l).OrderBy(x => x.ProductID);
            //int pageSize = 10;
            //int pageNumber = (page ?? 1);
            return View();

        }
        [HttpGet]
        public ActionResult FitterCaterogy()
        {
            IEnumerable<CategoryList> categoryList = GetCategoryLists();
            return PartialView("categoryView", categoryList);
        }
        [HttpPost]
        public ActionResult FitterCaterogy(QuerycateModel data)
        {
            var categoryList = GetCategoryLists();

            int maxRow = 3;

            try
            {
                if (data.TypeCN != null)
                {
                    categoryList = (from product in categoryList
                                    where data.TypeCN.Contains(product.TypeCN)
                                    .Skip((data.PageIndex - 1) * maxRow)
                                    select product).ToList();
                }
                if (data.TypeL != null)

                {
                    categoryList = (from product in categoryList
                                    where data.TypeL.Contains(product.Type)
                                    select product).ToList();
                }
                if (data.BrandList != null)
                {

                    categoryList = (from product in categoryList
                                    where data.BrandList.Contains(product.Brand)
                                    select product).ToList();
                }
                else
                {
                    categoryList = (from product in categoryList
                                    select product).ToList();
                }
            }
            catch (ArgumentException)
            {

            }
            List<CategoryList> list = categoryList.Distinct().ToList();

            return PartialView("categoryView", list);
        }

        [HttpPost]
        public ActionResult SortCategory(QuerycateModel data)
        {
            var categoryList = GetCategoryLists();
            Console.WriteLine(data);
            try
            {


                if (data.TypeL != null)
                {
                    categoryList = (from product in categoryList
                                    where data.TypeL.Contains(product.Type)
                                    select product).ToList();

                }
                if (data.TypeCN != null)
                {

                    categoryList = (from product in categoryList
                                    where data.TypeCN.Contains(product.TypeCN)
                                    select product).ToList();

                }
                if (data.BrandList != null)
                {
                    categoryList = (from product in categoryList
                                    where data.BrandList.Contains(product.Brand)
                                    select product).ToList();
                }
                if (data.Order != null)
                {
                    if (data.Order == "1")
                    {
                        categoryList = categoryList.OrderBy(x => x.Discount).ToList();
                    }
                    if (data.Order == "2")
                    {
                        categoryList = categoryList.OrderByDescending(x => x.Price).ToList();
                    }
                    if (data.Order == "3")
                    {
                        categoryList = categoryList.OrderBy(x => x.Price).ToList();
                    }
                }
            }
            catch (ArgumentException)
            {
                categoryList = (from product in categoryList
                                select product).ToList();
                if (data.Order != null)
                {
                    if (data.Order == "1")
                    {
                        categoryList = categoryList.OrderBy(x => x.Discount).ToList();
                    }

                    if (data.Order == "2")
                    {
                        categoryList = categoryList.OrderByDescending(x => x.Price).ToList();
                    }

                    if (data.Order == "3")
                    {
                        categoryList = categoryList.OrderBy(x => x.Price).ToList();
                    }
                }
            }

            return PartialView("categoryView", categoryList);
        }
        public JsonResult GetCountProduct(QuerycateModel data)
        {
            var categoryList = GetCategoryLists();
            Console.WriteLine(data);
            try
            {
                if (data.TypeCN != null)
                {
                    categoryList = (from product in categoryList
                                    where data.TypeCN.Contains(product.TypeCN)
                                    select product).ToList();
                }
                if (data.TypeL != null)

                {
                    categoryList = (from product in categoryList
                                    where data.TypeL.Contains(product.Type)
                                    select product).ToList();
                }
                if (data.BrandList != null)
                {

                    categoryList = (from product in categoryList
                                    where data.BrandList.Contains(product.Brand)
                                    select product).ToList();
                }
                else
                {
                    categoryList = (from product in categoryList
                                    select product).ToList();
                }
            }
            catch (ArgumentException)
            {

            }
            List<CategoryList> list = categoryList.Distinct().ToList();

            return Json(list.Count());
        }
    }
}
