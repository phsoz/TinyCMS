using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class Category : BaseEntity
    {
        public long ParentId { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public IList<PostCategory> PostCategories { get; set; }
        public Category ParentCategory { get; set; }
        public IList<Category> ChildCategories { get; set; }
    }
}
