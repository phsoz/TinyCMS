using TinyCMS.Domain.Entities;

namespace TinyCMS.Application.Interfaces
{
    public interface IAuthService
    {
        public Task<User> Login(string username, string password);
        public Task<User> CreateUser(User user);
    }
}
