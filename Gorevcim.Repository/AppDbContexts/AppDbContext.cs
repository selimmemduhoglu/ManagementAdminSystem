using Gorevcim.Core;
using Gorevcim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.AppDbContexts.AppDbContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductBrands> ProductBrands { get; set; }
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<ProductCurrencyUnits> ProductCurrencyUnits { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }

        public DbSet<ProductMeasurementUnits> ProductMeasurementUnits { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductWeightUnits> ProductWeightUnits { get; set; }
        public DbSet<ProductVatUnits> ProductVatUnits { get; set; }
        public DbSet<ProductProjects> ProductProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }






    }
}
