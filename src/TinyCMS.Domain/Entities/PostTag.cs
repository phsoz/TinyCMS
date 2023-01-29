using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class PostTag : BaseEntity
    {
        public long PostId { get; set; }
        public Post Post { get; set; }

        public long TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
