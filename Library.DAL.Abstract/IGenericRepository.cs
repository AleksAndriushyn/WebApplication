using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T GetEntity(int id);
        IList<T> EntityList();
        IList<T> List(Expression<Func<T, bool>> expression);
        void EntityInsert(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
        void DeleteEntity(int id);
    }
}
