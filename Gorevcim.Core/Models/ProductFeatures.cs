using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class ProductFeatures : BaseEntity
    {
        public int ProductId { get; set; }

        public Products Products { get; set; }
        public ProductBrands ProductBrands { get; set; }

        public ProductColors ProductColors { get; set; }

        public ProductCurrencyUnits ProductCurrencyUnits { get; set; }

        public ProductMeasurementUnits ProductMeasurementUnits { get; set; }

        public ProductWeightUnits ProductWeightUnits { get; set; }

        public ProductVatUnits ProductVatUnits { get; set; }

        public ProductProjects ProductProjects { get; set; }

    }
}
