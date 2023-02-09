using TinyCMS.Application.Contracts.Persistence;
using TinyCMS.Domain.Entities;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Infrastructure.Repositories
{
    public class PostTagRepository : BaseRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
