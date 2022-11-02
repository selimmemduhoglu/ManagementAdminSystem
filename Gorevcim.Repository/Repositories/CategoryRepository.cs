using Gorevcim.Core.Models;
using Gorevcim.Core.Repositories;
using Gorevcim.Repository.AppDbContexts.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(AppDbContext context) : base(context)
        {

                
        }
        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.Include(x => x.Id).ToListAsync();
        }



        public async Task<Category> GetCategoryIdProductsAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }


        public async Task<Category> GetApiCategoryIdProductsAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }

        public async Task<Category> GetWebCategoryIdProductAsync(int categoryId)
        {
            return await _context.Categories.Include(x => x.Products).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }

        public async Task<List<Category>> GetApiAllCategoriesAsync()
        {
            return await _context.Categories.Include(x => x.Id).ToListAsync();
        }


        public async Task<List<Category>> GetWebAllCategoriesAsync()
        {
            return await _context.Categories.Include(x => x.Id).ToListAsync();
        }

        public Task<Category> GetWebCategoryIdProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
