using TinyCMS.Application.Contracts.Persistence;
using TinyCMS.Domain.Entities;
using TinyCMS.Infrastructure.Persistence;

namespace TinyCMS.Infrastructure.Repositories
{
    public class PostCommentRepository : BaseRepository<PostComment>, IPostCommentRepository
    {
        public PostCommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
