using Microsoft.AspNetCore.Identity;

namespace TinyCMS.Domain.Entities
{
    public class User : IdentityUser<long>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public DateTime? RegisteredAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Intro { get; set; }
        public string Profile { get; set; }
        public IList<Post> Posts { get; set; }
    }
}
