using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TinyCMS.Domain.Common;
using TinyCMS.Domain.Entities;

namespace TinyCMS.Infrastructure.Persistence
{
    public partial class ApplicationDbContext : IdentityDbContext<User, Role, long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostMeta> PostMetas { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        //public DbSet<User> AppUsers { get; set; }

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
