using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductProjectsRepository : IGenericRepository<ProductProjects>
    {
        Task<List<ProductProjects>> GetApiAllProductProjectsAsync();
        Task<List<ProductProjects>> GetWebAllProductProjectsAsync();
    }
}
