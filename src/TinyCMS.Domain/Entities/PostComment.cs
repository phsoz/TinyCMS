using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class PostComment : BaseEntity
    {
        public long PostId { get; set; }
        public long ParentId { get; set; }
        public string Title { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
    }
}
