using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class PostCategory : BaseEntity
    {
        public long PostId { get; set; }
        public long CategoryId { get; set; }
    }
}
