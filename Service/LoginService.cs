using CoreProject.Auth;
using CoreProject.IService;

namespace CoreProject.Service
{
    public class LoginService : ILoginService
    {
        private readonly DbEntitys _dbEntity;

        public LoginService(DbEntitys dbEntitys)
        {
            _dbEntity = dbEntitys;
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return "";
            var token = ApplicationDbContext.CreateToken();
            return token;
        }
    }
}
