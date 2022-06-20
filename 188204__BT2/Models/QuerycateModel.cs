using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _188204__BT2.Models
{
    public class QuerycateModel
    {
        public string Order { get; set; }
        public List<int> TypeCN { get; set; }
        public List<int> TypeL { get; set; }
        public List<int> BrandList { get; set; }

        public int PageIndex { get; set; }

    }
}
