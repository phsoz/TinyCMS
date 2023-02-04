using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TinyCMS.Infrastructure.Persistence
{
    public class TinyContextFactory : IDesignTimeDbContextFactory<TinyDatabaseContext>
    {
        public TinyDatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TinyDatabaseContext>();
            optionsBuilder.UseSqlite("Data Source=D:/TinyDatabase.db");

            return new TinyDatabaseContext(optionsBuilder.Options);
        }
    }
}
