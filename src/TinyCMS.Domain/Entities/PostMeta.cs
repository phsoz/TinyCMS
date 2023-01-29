using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class PostMeta : BaseEntity
    {
        public long PostId { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }
    }
}
