using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Chinook.Repositories.GenericRepository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ChinookContext _dbContext { get; set; }
        public RepositoryBase(ChinookContext Context)
        {
            _dbContext = Context;
        }
        public IQueryable<T> FindAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity) => _dbContext.Set<T>().Remove(entity);
    }
}
