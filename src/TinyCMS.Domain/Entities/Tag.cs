using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public IList<PostTag> PostTags { get; set; }
    }
}
