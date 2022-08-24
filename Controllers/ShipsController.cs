using CoreProject.CommonHelper;
using CoreProject.DataModel;
using CoreProject.IService;
using CoreProject.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreProject.CommonMethod;

namespace CoreProject.Controllers
{
    [Route("api/ship")]
    [ApiController]
    //[Authorize]
    public class ShipsController : ControllerBase
    {
        private readonly DbEntitys _context;
        private readonly IShipService _shipService;


        public ShipsController(DbEntitys context, IShipService shipService)
        {
            _context=context;
            _shipService=shipService;
        }

        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> SaveLube(LubeInfo request)
        {
            var res = await _shipService.SaveLube(request);
            return Ok(res);
        }

        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("find")]
        public async Task<IActionResult> FindAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return Ok(Result.Fail("参数不能为空"));
            var res = await _shipService.FindAsync(id);
            return Ok(new APIResult<ShipInfo>(res));
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("query")]
        public async Task<IActionResult> QueryAsync(string name, int page, int rows)
        {
            var res = await _shipService.QueryAsync(name);
            return Ok(new APIPageResult<ShipInfo>(res, page, rows));
        }
    }
}
