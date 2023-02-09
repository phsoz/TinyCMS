using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;
using TinyCMS.Domain.Common;

namespace TinyCMS.Application.Contracts.Persistence
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetOneAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        string includeString = null,
                                        bool disableTracking = true);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                        List<Expression<Func<T, object>>> includes = null,
                                        bool disableTracking = true);
        Task<T> GetByIdAsync(long id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task MultipleUpdateAsync(IReadOnlyList<T> lstEntity);
        Task DeleteAsync(T entity);
        Task MultipleDeleteAsync(IReadOnlyList<T> lstEntity);
        Task<int> SaveChangeAsync();
    }
}
