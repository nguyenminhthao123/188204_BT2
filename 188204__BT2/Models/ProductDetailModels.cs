using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _188204__BT2.Models
{
    public class ProductDetailModels
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public List<infoTechModel> InfoTeach { get; set; }
        public List<PolicyModel> Policy { get; set; }
        public List<ImagethumpModel> Imagethump { get; set; }
        public List<ProductFeaturesModel> ProductFeatures { get; set; }
        public List<UseManualModel> UseManual { get; set; }
    }
}
