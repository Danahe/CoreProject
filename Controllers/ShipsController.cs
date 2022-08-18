using CoreProject.CommonHelper;
using CoreProject.DataModel;
using CoreProject.IService;
using CoreProject.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAnnualPartForm()
        {
            var con = AppSettingsHelper.Configuration["ConnectionStrings:DefaultConnection"];
            var model =  await _context.Ships.FirstOrDefaultAsync();
            return Ok(model);
        }

        [HttpGet]
        [Route("get-lube")]
        public async Task<IActionResult> GetLube()
        {
            var model = await _context.LubeInfos.FirstOrDefaultAsync();
            return Ok(model);
        }

        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> SaveLube(LubeInfo request)
        {
            var res = await _shipService.SaveLube(request);
            return Ok(res);
        }
    }
}
