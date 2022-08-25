using CoreProject.DataModel;
using CoreProject.DtoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreProject.CommonMethod;

namespace CoreProject.IService
{
    public interface IFileService
    {
        Task<FileUploadReply> FileUpload(FileUploadRequest request);

        Task<FileData> FindAsync(string id);

        Task<Result> FilesUploadAsync(List<IFormFile> files);
    }
}
