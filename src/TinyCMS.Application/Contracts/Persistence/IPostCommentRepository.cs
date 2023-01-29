using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCMS.Domain.Entities;

namespace TinyCMS.Application.Contracts.Persistence
{
    public interface IPostCommentRepository : IBaseRepository<PostComment>
    {
    }
}
