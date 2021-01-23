using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Concrete;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntitiy, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}