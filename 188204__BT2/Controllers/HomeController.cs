using _188204__BT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _188204__BT2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /* Khai báo data ProductList*/
        public List<ProductListModel> GetProductList()
        {
            List<ProductListModel> productList = new List<ProductListModel>()
            {
                new ProductListModel { ProductID=1,Name="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",Image="/Images/1.jpg",Price=629000,Discount=20,DetailProduct=GetProductDetail()},
                new ProductListModel { ProductID=2,Name="Đồ chơi trẻ em: Lắp ráp chiến xe monster jam™ el toro loco™ Lego 42135 (247 chi tiết) - Màu ngẫu nhiên",Image="/Images/2.jpg",Price=799000,Discount=20,DetailProduct=GetProductDetail()},
                new ProductListModel { ProductID=3,Name="Đồ chơi trẻ em: Lắp ráp xe cảnh sát truy đuổi tên cướp xe kem Lego 60315 (317 chi tiết) - Màu ngẫu nhiên",Image="/Images/3.jpg",Price=1399000,Discount=20,DetailProduct=GetProductDetail()},
                new ProductListModel { ProductID=4,Name="Đồ chơi buổi biểu diễn ảo thuật nhào lộn Lego Friends 41686 (223 chi tiết)",Image="/Images/4.jpg",Price=649000,Discount=20,DetailProduct=GetProductDetail()},
                new ProductListModel { ProductID=5,Name="Đồ chơi rồng đen của chúa tể Overlord Lego Ninjago 71742 (372 chi tiết)",Image="/Images/5.jpg",Price=869000,Discount=20,DetailProduct=GetProductDetail()},
                new ProductListModel { ProductID=6,Name="Đồ chơi ngôi nhà trên cây Lego Friends 41679 (326 chi tiết)",Image="/Images/1.jpg",Price=899000,Discount=20,DetailProduct=GetProductDetail()},
            };
            return productList;
        }

        /* Khai báo data InfoTeach*/
        public List<infoTechModel>  GetinfoTech()
        {
            List<infoTechModel> infoTeach = new List<infoTechModel>()
            {
                new infoTechModel{ IdInfo = 1,NameInfo = "Thương hiệu", ValueInfo = "Thụy Sỹ", },
                new infoTechModel{ IdInfo = 2,NameInfo = "Loại", ValueInfo = "Đồ chơi lắp ráp", },
                new infoTechModel{ IdInfo = 3,NameInfo = "Độ tuổi", ValueInfo = "Từ 5 tuổi trở lên", },
                new infoTechModel{ IdInfo = 4,NameInfo = "Chất liệu", ValueInfo = "Nhựa", },
                new infoTechModel{ IdInfo = 5,NameInfo = "Kích thước hộp", ValueInfo = "38x26x6 cm", },
                new infoTechModel{ IdInfo = 6,NameInfo = "Trọng lượng", ValueInfo = "724 g", },
                new infoTechModel{ IdInfo = 7,NameInfo = "Lưu ý khi sử dụng", ValueInfo = "Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai", },
                new infoTechModel{ IdInfo = 8,NameInfo = "Nơi sản xuất", ValueInfo = "Trung Quốc", },

            };
            return infoTeach;
        }

        /*Khai báo data Policy*/
        public List<PolicyModel> GetPolicy()
        {
            List<PolicyModel> infoTeach = new List<PolicyModel>()
            {
                new PolicyModel{ Icon="fa-solid fa-arrows-rotate",NamePolicy="Không áp dụng đổi trả, bảo hành (Không bao gồm xe đồ chơi điều khiển)Xem chi tiết"},
                new PolicyModel{ Icon="fa-solid fa-truck",NamePolicy="Miễn phí giao hàng đơn từ 500.000đ trong 10km đầu tiên"},
                new PolicyModel{ Icon="fa-brands fa-amazon-pay",NamePolicy="Giao hàng thu tiền, thanh toán online nhiều phương thức"},
                new PolicyModel{ Icon="fa-solid fa-headset",NamePolicy="Tổng đài:1900.866.874   (7h30 - 22h00)"},
            };
            return infoTeach;
        }

        /*khai báo data image*/
        public List<ImagethumpModel> GetImageThump()
        {
            List<ImagethumpModel> Imgdetail = new List<ImagethumpModel>
            {
                new ImagethumpModel {Img="/Images/1.jpg"},
                new ImagethumpModel {Img="/Images/2.jpg"},
                new ImagethumpModel {Img="/Images/3.jpg"},
                new ImagethumpModel {Img="/Images/4.jpg"},
                new ImagethumpModel {Img="/Images/5.jpg"},
                new ImagethumpModel {Img="/Images/5.jpg"},
            };
            return Imgdetail;
        }

        /*khai báo data đặc điểm nổi bật */
        public List<ProductFeaturesModel> GetProductFeatures ()
        {
            List<ProductFeaturesModel> Features = new List<ProductFeaturesModel>
            {
                new ProductFeaturesModel {NameFeature="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 bao gồm 297 chi tiết."},
                new ProductFeaturesModel {NameFeature="Bé có thể sáng tạo và tưởng tượng câu chuyện của mình."},
                new ProductFeaturesModel {NameFeature="Đồ chơi lắp ráp giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp."},
                new ProductFeaturesModel {NameFeature="Đồ chơi Lego City không có góc nhọn, thành phần độc hại nên an toàn cho bé."},

            };
            return Features;
        }

        /*khai báo data cho hướng dẫn sử dụng*/

        public List<UseManualModel> GetUseManual ()
        {
            List<UseManualModel> useManua = new List<UseManualModel>
            {
                new UseManualModel { context = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."},
                new UseManualModel { context = "Có thể sáng tạo theo trí tưởng tượng của bé."}
            };
            return useManua;
        }

        /* Khai báo data ProductDetail*/
        public ProductDetailModels  GetProductDetail()
        {
          var ProductDetail = new ProductDetailModels()
            {
              InfoTeach = GetinfoTech(),
              Policy=GetPolicy(),
              Imagethump=GetImageThump(),
              ProductFeatures= GetProductFeatures(),
              UseManual = GetUseManual(),

          };
            return ProductDetail;
        }

        public IActionResult Index( int id)
        {
            CollectionDataModel model = new CollectionDataModel();
            var product = GetProductList().Find(x => x.ProductID == id);
             
            model.ProductDeatail = product;
            model.ProductList = GetProductList();
            return View(model);
        }
       
        public IActionResult DetailView ()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
