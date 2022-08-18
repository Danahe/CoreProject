using CoreProject.Auth;
using CoreProject.DataModel;
using CoreProject.IService;

namespace CoreProject.Service
{
    public class ShipService : IShipService
    {
        private readonly DbEntitys _context;

        public ShipService(DbEntitys context)
        {
            _context = context;
        }

        public async Task<string> SaveLube(LubeInfo request)
        {
            var model = new LubeInfo()
            {
                Id = request.Id,
                Type=request.Type,
                No=request.No,
                Model=request.Model,
                Unit=request.Unit,
                Brand=request.Brand,
                Remark=request.Remark,
            };
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            return "提交成功";
        }
    }
}
