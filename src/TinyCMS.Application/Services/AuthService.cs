using TinyCMS.Application.Interfaces;
using TinyCMS.Domain.Entities;

namespace TinyCMS.Application.Services
{
    public class AuthService : IAuthService
    {
        public Task<User> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
