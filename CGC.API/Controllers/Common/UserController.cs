using CGC.Application.IService;
using CGC.Domain.Entity.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CGC.API.Controllers.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }
        [HttpGet("GetAll")]
        public async Task<IEnumerable<User>> GetAll()
        {
           var  list=await _userService.GetUserList();

            return list;
        }
        [HttpGet("GetById")]
        public  User GetById(string id)
        {
            var list =  _userService.GetUserById(id);

            return list;
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] User obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            await _userService.AddUser(obj);

            return Ok(obj);

        }
        [HttpPut("Update")]
        public async Task UpdateUser(string id, User obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            await _userService.UpdateUser(id, obj);

           
        }
        [HttpDelete("Delete")]
        public async Task Delete(User obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            await _userService.DeleteUser(obj);

        }
    }
}
