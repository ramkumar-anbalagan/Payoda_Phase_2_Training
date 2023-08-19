using JWT_Auth.Models;
using JWT_Auth.Services.Interface;
using Microsoft.EntityFrameworkCore;
using StudentDetails.GlobalExceptions;

namespace JWT_Auth.Services
{
    public class UserService : IUser
    {
        private StudentContext _context;

        public UserService(StudentContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUserTable(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var users= await _context.Users.ToListAsync();
            return users;
        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var users = await _context.Users.FindAsync(username);
            if (users != null)
            {
                _context.Users.Remove(users);
                _context.SaveChangesAsync();
                return await _context.Users.ToListAsync();
            }
            return null;
        }

        

        public async Task<User> GetUserByUsername(string username)
        {
            var users = await _context.Users.FindAsync(username);
            if (users != null)
            {
                throw new Exception(StudentDetailsExceptions.ExceptionMessages[1]);
            }
            return users;
        }

        public async Task<User> UpdateUser(string username, User user)
        {
            var users = await _context.Users.FindAsync(username);
            if (users != null)
            {
                users.Password = user.Password;
                users.Role = user.Role;

                _context.SaveChanges();
                users = await _context.Users.FindAsync(username);
                return users;
            }
            return null;
        }
    }
}
