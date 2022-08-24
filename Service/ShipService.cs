using CoreProject.Auth;
using CoreProject.DataModel;
using CoreProject.IService;
using CoreProject.CommonMethod;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.Service
{
    public class ShipService : IShipService
    {
        private readonly DbEntitys _context;

        public ShipService(DbEntitys context)
        {
            _context = context;
        }

        public async Task<ShipInfo> FindAsync(string id)
        {
            var reply = new ShipInfo();
            var model = await _context.Ships.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (model == null) return reply;
            return model;
        }

        public async Task<List<ShipInfo>> QueryAsync(string name)
        {
            var query = _context.Ships.Where(x => x.DeleteFlag == false).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(x => x.Name.Contains(name));
            }
            var reply=await query.ToListAsync();
            return reply;
        }

        public async Task<Result> SaveLube(LubeInfo request)
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
            return Result.Success("保存成功");
        }
    }
}
