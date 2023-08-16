using JWTAuth.Models;

namespace JWTAuth.Services.Interfaces
{
    public interface IUsers
    {
        Task<User> GetUserByUserName(string username);

        Task<List<User>> AddUser(User user); 

        Task<User>UpdateUser(string username, User user);

        Task<List<User>> DeleteUser(string username);
    }
}
