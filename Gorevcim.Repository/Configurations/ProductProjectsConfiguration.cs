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
    internal class ProductProjectsConfiguration : IEntityTypeConfiguration<ProductProjects>
    {
        public void Configure(EntityTypeBuilder<ProductProjects> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.ShortCode).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(500);
            builder.HasOne(x => x.ProductFeatures).WithOne(x => x.ProductProjects).HasForeignKey<ProductProjects>(x => x.ProductFeaturesId);
        }

    }
}
