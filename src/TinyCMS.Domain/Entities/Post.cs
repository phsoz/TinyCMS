using TinyCMS.Domain.Common;

namespace TinyCMS.Domain.Entities
{
    public class Post : BaseEntity
    {
        public long AuthorId { get; set; }
        public long ParentId { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public bool Published { get; set; }

        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }

        public IList<PostComment> Comments { get; set; }
        public IList<PostMeta> Metas { get; set; }
        public IList<PostCategory> PostCategories { get; set; }
        public IList<PostTag> PostTags { get; set; }
        public User Author { get; set; }
        public Post ParentPost { get; set; }
        public IList<Post> ChildPosts { get; set; }
    }
}
