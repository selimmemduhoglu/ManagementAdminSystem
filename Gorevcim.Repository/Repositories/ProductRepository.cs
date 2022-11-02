using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using Gorevcim.Repository.AppDbContexts.AppDbContext;
using Gorevcim.Core.Models;
using System.Security.Cryptography.X509Certificates;

namespace Gorevcim.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductsRepository
    {
        public ProductRepository(AppDbContext context ):base (context)
        {
          

        }
        public async Task<List<Products>> GetProductsCategorys()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsCategoryAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetApiAllProductsCategoryAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetAllProductsCategoryAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }



    }
}
