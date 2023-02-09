using TinyCMS.Application.Contracts.Persistence;
using TinyCMS.Domain.Entities;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
