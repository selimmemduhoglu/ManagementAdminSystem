﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> GetByIdAsync(int Id);

        IQueryable<T> Where(Expression<Func< T, bool>> expression);

        Task<int> AnyAsync(Expression<Func< T, bool>> expression);

        IQueryable<T> GetAll();
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entites);

        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entites);

    }
}
