using CoreProject.DataModel;
using CoreProject.DtoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreProject.CommonMethod;

namespace CoreProject.IService
{
    public interface IUserService
    {
        Task<Result> SaveUserAsync(UserItem request);

        Task<string> LoginAsync(string mobile, string password);

        Task<UserItem> FindAsync(string id);
    }
}
