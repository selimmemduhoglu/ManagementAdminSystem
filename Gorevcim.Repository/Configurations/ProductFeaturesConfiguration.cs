using Gorevcim.Core;
using Gorevcim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Configurations
{
    internal class ProductFeaturesConfiguration:IEntityTypeConfiguration<ProductFeatures>
    {
        public void Configure(EntityTypeBuilder<ProductFeatures> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Products).WithOne(x => x.ProductFeatures).HasForeignKey<ProductFeatures>(x => x.ProductId);
        }
    }
}
