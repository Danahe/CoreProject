using CoreProject.DataModel;
using CoreProject.DtoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreProject.IService
{
    public interface IUserService
    {
        Task<bool> SaveUserAsync(UserItem request);

        Task<string> LoginAsync(string mobile, string password);

        Task<UserItem> FindAsync(string id);
    }
}
