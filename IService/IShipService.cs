using CoreProject.CommonMethod;
using CoreProject.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreProject.IService
{
    public interface IShipService
    {
        Task<Result> SaveLube(LubeInfo request);

        Task<ShipInfo> FindAsync(string id);

        Task<List<ShipInfo>> QueryAsync(string name);

    }
}
