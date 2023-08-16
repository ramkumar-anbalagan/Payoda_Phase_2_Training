using JWTAuth.Models;
using JWTAuth.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUsers _user;

        public UserController(IUsers user) 
        {
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUserByUserName(string userName)
        {
            try
            {
                var user = await _user.GetUserByUserName(userName);
                return Ok(user);

            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        public async Task<ActionResult<List<User>>> AddUser(User user)
        { 
            return Ok(await _user.AddUser(user));   
        }

        public async Task<ActionResult<User>> UpdateUser(string username, User user)
        {
            try
            {
                return Ok(await _user.UpdateUser(username, user));

            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        public async Task<ActionResult<List<User>>> DeleteUser(string username) {
            try { 
                return Ok(_user.DeleteUser(username));
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        
        }
    }
}
