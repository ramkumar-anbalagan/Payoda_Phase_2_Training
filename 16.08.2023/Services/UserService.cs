using JWTAuth.GlobalExceptions;
using JWTAuth.Models;
using JWTAuth.Services.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.Services
{
    public class UserService : IUsers
    {
        public StudentContext _context;

        public UserService(StudentContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            var users= await _context.Users.ToListAsync<User>();
            return users;
        }

        public async Task<List<User>> DeleteUser(string username)
        {
            var user =await _context.Users.FindAsync(username);
            if (user == null) { 
                _context.Users.Remove(user);
                _context.SaveChanges();
                var alluser= await _context.Users.ToListAsync<User>();
                return alluser;
            }
             throw new Exception(UserException.UserDetailExceptions[0]);
        }

        public async Task<User> GetUserByUserName(string username)
        {
            var users =  await _context.Users.FindAsync(username);
            if (users == null) {
                throw new Exception(UserException.UserDetailExceptions[0]);
            }
            return users;

        }

        public async Task<User> UpdateUser(string username, User user)
        {
            User rusers = await _context.Users.FindAsync(username);
            if (rusers == null)
            {
                rusers.Password = user.Password;
                rusers.Role = user.Role;
                await _context.SaveChangesAsync();
                 return await _context.Users.FindAsync(username);
            
            }
            else {
                throw new Exception(UserException.UserDetailExceptions[0]);
            }
            


        }
    }
}
