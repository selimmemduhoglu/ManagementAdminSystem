﻿using Gorevcim.Core;
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
    public class ProductVatUnitsConfiguration : IEntityTypeConfiguration<ProductVatUnits>
    {
        public void Configure(EntityTypeBuilder<ProductVatUnits> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);

            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.HasOne(x => x.ProductFeatures).WithOne(x => x.ProductVatUnits).HasForeignKey<ProductVatUnits>(x => x.ProductFeaturesId);
        }

    }
}
