using Gorevcim.Core;
using Gorevcim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(new Products
            {
                Id = 1,
                CategoryId = 1,
                Name = "Test Ürün1",
                Code = "123AS",
                Barcode = "AS123",
                ExpirationDate = DateTime.Now,
                Explanation = "hghghgh",
                PurchasePrice = 10,
                SalePrice = 15,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                ExplanationWebUrl = "dlld",
                LogoBase64Content = "ad",
                LogoFileName = "sdf",
                TechnicalWebUrl = "dfsd",
                LogoFilePath = "sdsdf",
                IsMixture = 1,
                Stock = 1


            });
        }
    }
}
