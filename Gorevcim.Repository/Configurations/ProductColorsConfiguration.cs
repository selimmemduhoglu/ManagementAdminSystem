using Gorevcim.Core;
using Gorevcim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Configurations
{
    internal class ProductColorsConfiguration : IEntityTypeConfiguration<ProductColors>
    {
        public void Configure(EntityTypeBuilder<ProductColors> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Code).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.ColorFileName).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.ColorFilePath).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.HasOne(x => x.ProductFeatures).WithOne(x => x.ProductColors).HasForeignKey<ProductColors>(x => x.ProductFeaturesId);
        }
    }
}
