using CoreProject.Auth;
using CoreProject.DtoModel;
using CoreProject.IService;
using CoreProject.DataModel;
using CoreProject.CommonMethod;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.Service
{
    public class UserService : IUserService
    {
        private readonly DbEntitys _context;

        public UserService(DbEntitys context)
        {
            _context = context;
        }

        public async Task<UserItem> FindAsync(string id)
        {
            var reply=new UserItem();
            var model = await _context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (model is null) return reply;
            reply.Id = model.Id;
            reply.Name = model.Name;
            reply.Mobile = model.Mobile;
            return reply;
        }

        public async Task<string> LoginAsync(string mobile, string password)
        {
            var md5password = SystemCommonMethod.MD5Encryption(password);
            var model = await _context.Users.Where(x => x.Mobile == mobile && x.Password== md5password && x.DeleteFlag == false).FirstOrDefaultAsync();
            if (model is null) return "登录失败";
            var token = ApplicationDbContext.CreateToken(mobile, md5password);
            return token;
        }

        public async Task<bool> SaveUserAsync(UserItem request)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
            {
                var haveModel = await _context.Users.Where(x => x.Mobile == request.Mobile && x.DeleteFlag == false).FirstOrDefaultAsync();
                if (haveModel is not null) return false;
                var addModel = new User()
                {
                    Id = SystemCommonMethod.GetGuid(),
                    Name = request.Name,
                    Mobile = request.Mobile,
                    Password = SystemCommonMethod.MD5Encryption(request.Password),
                };
                await _context.AddAsync(addModel);
            }
            else
            {
                var model = await _context.Users.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (model is null) return false;
                model.Name = request.Name;
                model.Mobile = request.Mobile;
                model.Password = SystemCommonMethod.MD5Encryption(request.Password);
                model.ModifyDate = DateTime.Now;
                model.PushFlag = false;
                _context.Update(model);
            }
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
