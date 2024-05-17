using System;
using System.Linq;
using System.Linq.Expressions;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        // Mark an entity as new
        void Add(T entity);

        // Mark an entity as modified
        void Update(T entity);

        // Mark an entity as removed
        void Delete(T entity);

        // delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // Mark an entity by int ID
        T GetSingleById(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes=null);
        IQueryable<T> GetAll(string[]includes=null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}