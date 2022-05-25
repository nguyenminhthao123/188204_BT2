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
        public string CovertNumber(decimal price)
        {
            var NewPrice = price.ToString();
            var lenght = NewPrice.Length;
            while (lenght >= 0)
            {

                if (lenght - 3 > 0)
                {
                    NewPrice = NewPrice.Insert(lenght - 3, ".");
                }
                lenght =lenght - 3;
            }
            return NewPrice;
        }
        public string Calcula()
        {
            var price_current = Price - (Price * Discount) / 100;
            return CovertNumber(price_current);
        }
        public string FormatPrice()
        {
            return CovertNumber(Price);
        }
    }
}
