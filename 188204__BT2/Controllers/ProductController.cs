
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _188204__BT2.Models;
namespace _188204__BT2.Controllers
{
    public class ProductController : Controller
    {
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
        public List<InfoTechModel> GetinfoTech()
        {
            List<InfoTechModel> infoTeach = new List<InfoTechModel>()
            {
                new InfoTechModel{ IdInfo = 1,NameInfo = "Thương hiệu", ValueInfo = new List<string>(){"Lego (Đan Mạch)" }, },
                new InfoTechModel{ IdInfo = 2,NameInfo = "Loại", ValueInfo = new List<string>(){"Đồ chơi bé trai","Đồ chơi lắp ráp" }, },
                new InfoTechModel{ IdInfo = 3,NameInfo = "Độ tuổi", ValueInfo = new List<string>(){"Từ 5 tuổi trở lên" }, },
                new InfoTechModel{ IdInfo = 4,NameInfo = "Chất liệu", ValueInfo = new List<string>(){"Nhựa" }, },
                new InfoTechModel{ IdInfo = 5,NameInfo = "Kích thước hộp", ValueInfo = new List<string>(){"38x26x6 cm" }, },
                new InfoTechModel{ IdInfo = 6,NameInfo = "Trọng lượng", ValueInfo = new List<string>(){"724 g" }, },
                new InfoTechModel{ IdInfo = 7,NameInfo = "Lưu ý khi sử dụng", ValueInfo = new List<string>(){"Có các chi tiết nhỏ, không dùng cho trẻ dưới 3 tuổi, tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai" }, },
                new InfoTechModel{ IdInfo = 8,NameInfo = "Nơi sản xuất", ValueInfo = new List<string>(){"Trung Quốc" }, },

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
        public List<ProductFeaturesModel> GetProductFeatures()
        {
            List<ProductFeaturesModel> Features = new List<ProductFeaturesModel>
            {
                new ProductFeaturesModel {NameFeature=" bao gồm 297 chi tiết.",NameFeatureLink="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308"},
                new ProductFeaturesModel {NameFeature="Bé có thể sáng tạo và tưởng tượng câu chuyện của mình.",NameFeatureLink=""},
                new ProductFeaturesModel {NameFeature=" giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp.",NameFeatureLink="Đồ chơi lắp ráp"},
                new ProductFeaturesModel {NameFeature=" không có góc nhọn, thành phần độc hại nên an toàn cho bé.",NameFeatureLink="Đồ chơi Lego City"},

            };
            return Features;
        }

        /*khai báo data cho hướng dẫn sử dụng*/

        public List<UseManualModel> GetUseManual()
        {
            List<UseManualModel> useManua = new List<UseManualModel>
            {
                new UseManualModel { ContextLink="Đồ chơi", Context = "không dùng pin."},
                new UseManualModel { ContextLink="", Context = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."},
                new UseManualModel { ContextLink="", Context = "Có thể sáng tạo theo trí tưởng tượng của bé."}
            };
            return useManua;
        }

        /* Khai báo data ProductDetail*/
        public ProductDetailModels GetProductDetail()
        {
            var ProductDetail = new ProductDetailModels()
            {
                InfoTeach = GetinfoTech(),
                Policy = GetPolicy(),
                Imagethump = GetImageThump(),
                ProductFeatures = GetProductFeatures(),
                UseManual = GetUseManual(),

            };
            return ProductDetail;
        }
        public IActionResult DetailView(int id)
        {
            CollectionDataModel model = new CollectionDataModel();
            var product = GetProductList().Find(x => x.ProductID == id);

            model.ProductDeatail = product;
            model.ProductList = GetProductList();
            return View(model);
        }

    }
}
