using Bll.Interfaces;
using Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBll userBll;
        public UserController(IUserBll userBll)
        {
            this.userBll = userBll;
        }
        [HttpGet]
        public List<UserDto> Get()
        {
            return this.userBll.getUsers();
        }
        [HttpPost]
        public UserDto Post([FromBody] UserDto userDto) {
            return this.userBll.addUser(userDto);
        }
    }
}
