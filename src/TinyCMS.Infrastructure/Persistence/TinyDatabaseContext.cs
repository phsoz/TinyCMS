using Microsoft.EntityFrameworkCore;
using TinyCMS.Domain.Common;
using TinyCMS.Domain.Entities;

namespace TinyCMS.Infrastructure.Persistence
{
    public partial class TinyDatabaseContext : DbContext
    {

        public TinyDatabaseContext(DbContextOptions<TinyDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostMeta> PostMetas { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .ToTable("post")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Post>()
                .HasOne(e => e.ParentPost)
                .WithMany(p => p.ChildPosts)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<Post>()
                .HasOne(e => e.Author)
                .WithMany(a => a.Posts)
                .HasForeignKey(u => u.AuthorId);

            modelBuilder.Entity<Category>()
                .ToTable("category")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Category>()
                .HasOne(e => e.ParentCategory)
                .WithMany(p => p.ChildCategories)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<PostCategory>()
                .ToTable("post_category")
                .HasKey(e => new { e.PostId, e.CategoryId });

            modelBuilder.Entity<PostCategory>()
                .HasOne(e => e.Post)
                .WithMany(p => p.PostCategories)
                .HasForeignKey(pc => pc.PostId);

            modelBuilder.Entity<PostCategory>()
                .HasOne(e => e.Category)
                .WithMany(c => c.PostCategories)
                .HasForeignKey(pc => pc.CategoryId);

            modelBuilder.Entity<PostComment>()
                .ToTable("post_comment")
                .HasKey(e => e.Id);

            modelBuilder.Entity<PostComment>()
                .HasOne(e => e.ParentComment)
                .WithMany(p => p.ChildComments)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<PostComment>()
                .HasOne(e => e.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(pc => pc.PostId);

            modelBuilder.Entity<PostMeta>()
                .ToTable("post_meta")
                .HasKey(e => e.Id);

            modelBuilder.Entity<PostMeta>()
                 .HasOne(e => e.Post)
                 .WithMany(p => p.Metas)
                 .HasForeignKey(pm => pm.PostId);

            modelBuilder.Entity<PostTag>()
                 .ToTable("post_tag")
                 .HasKey(e => new { e.TagId, e.PostId });

            modelBuilder.Entity<PostTag>()
                 .HasOne(e => e.Post)
                 .WithMany(p => p.PostTags)
                 .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<PostTag>()
                 .HasOne(e => e.Tag)
                 .WithMany(p => p.PostTags)
                 .HasForeignKey(pt => pt.TagId);

            modelBuilder.Entity<Tag>()
                 .ToTable("tag")
                 .HasKey(e => e.Id);

            modelBuilder.Entity<User>()
                 .ToTable("user")
                 .HasKey(e => e.Id);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //TO DO: modify audit fields before save change
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        //modify audit fields here
                        break;
                    case EntityState.Modified:
                        //modify audit fields here
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
