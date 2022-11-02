using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductsRepository : IGenericRepository<Products>
    {
        Task<List<Products>> GetApiAllProductsCategoryAsync();
        Task<List<Products>> GetWebAllProductsCategoryAsync();
        Task<List<Products>> GetWebAllProductsAsync();
    }
}
