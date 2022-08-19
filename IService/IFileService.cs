using CoreProject.DataModel;
using CoreProject.DtoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreProject.IService
{
    public interface IFileService
    {
        Task<FileUploadReply> FileUpload(FileUploadRequest request);

        Task<FileData> FindAsync(string id);
    }
}
