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
    internal class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.Property(x => x.Code).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Barcode).IsRequired(false).HasMaxLength(100);

            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.LogoFileName).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.LogoFilePath).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.TechnicalWebUrl).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.ExplanationWebUrl).IsRequired(false).HasMaxLength(500);
        }


    }
}
