using CoreProject.DataModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreProject.IService
{
    public interface IShipService
    {
        Task<string> SaveLube(LubeInfo request);

    }
}
