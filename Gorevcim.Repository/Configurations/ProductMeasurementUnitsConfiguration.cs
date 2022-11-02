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
    internal class ProductMeasurementUnitsConfiguration : IEntityTypeConfiguration<ProductMeasurementUnits>
    {
        public void Configure(EntityTypeBuilder<ProductMeasurementUnits> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.ShortCode).IsRequired(false).HasMaxLength(10);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(500);
            builder.HasOne(x => x.ProductFeatures).WithOne(x => x.ProductMeasurementUnits).HasForeignKey<ProductMeasurementUnits>(x => x.ProductFeaturesId);
        }

    }
}
