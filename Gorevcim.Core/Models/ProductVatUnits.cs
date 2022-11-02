using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class ProductVatUnits : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int IsExemption { get; set; }
        public string Explanation { get; set; }

        public int ProductFeaturesId { get; set; }
        public ProductFeatures ProductFeatures { get; set; }
    }
}
