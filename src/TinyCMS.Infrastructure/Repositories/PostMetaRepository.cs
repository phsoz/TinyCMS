using TinyCMS.Application.Contracts.Persistence;
using TinyCMS.Domain.Entities;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Infrastructure.Repositories
{
    public class PostMetaRepository : BaseRepository<PostMeta>, IPostMetaRepository
    {
        public PostMetaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
