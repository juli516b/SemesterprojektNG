using System.Threading.Tasks;
using Semesterprojekt.Core.Entites;

namespace Semesterprojekt.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}