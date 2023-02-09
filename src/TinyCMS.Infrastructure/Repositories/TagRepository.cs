using TinyCMS.Application.Contracts.Persistence;
using TinyCMS.Domain.Entities;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Infrastructure.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
