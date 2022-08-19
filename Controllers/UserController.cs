using CoreProject.DataModel;
using CoreProject.DtoModel;
using CoreProject.IService;
using CoreProject.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreProject.CommonMethod;

namespace CoreProject.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> Login(string mobile, string password)
        {
            var res = await _userService.LoginAsync(mobile, password);
            return Ok(res);
        }

        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> SaveUserAsync(UserItem request)
        {
            if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Mobile) || string.IsNullOrWhiteSpace(request.Password))
                return NotFound();
            var res = await _userService.SaveUserAsync(request);
            return Ok(res);
        }

        [HttpGet]
        [Route("find")]
        public async Task<IActionResult> FindAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return Ok(ResultMsg.Fail("参数不能为空"));
            var res = await _userService.FindAsync(id);
            return Ok(new APIResult<UserItem>(res));
        }
    }
}
