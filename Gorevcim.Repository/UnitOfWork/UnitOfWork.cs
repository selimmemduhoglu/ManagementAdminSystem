using Gorevcim.Core.UnitOfWork;
using Gorevcim.Repository.AppDbContexts.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.UnitOfWork
{
    public class UnitOfWork : IGenericUnitOfWork  
    {

        private readonly AppDbContexts.AppDbContext.AppDbContext _context;
        public UnitOfWork(AppDbContexts.AppDbContext.AppDbContext context)
        {

            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public async Task CommitAsync()
        {

            await _context.SaveChangesAsync();
        }

    }
}
