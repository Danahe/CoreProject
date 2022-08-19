using CoreProject.Auth;
using CoreProject.DtoModel;
using CoreProject.IService;
using CoreProject.DataModel;
using CoreProject.CommonMethod;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.Service
{
    public class FileService : IFileService
    {
        private readonly DbEntitys _context;

        public FileService(DbEntitys context)
        {
            _context = context;
        }

        public async Task<FileUploadReply> FileUpload(FileUploadRequest request)
        {
            var reply = new FileUploadReply();
            byte[] data =null;
            var stream = new MemoryStream();
            if (request.Data != null)
            {
                await request.Data.CopyToAsync(stream);
                data = new byte[stream.Length];
                stream.Seek(0, SeekOrigin.Begin);
                await stream.ReadAsync(data, 0, data.Length);
                stream.Seek(0, SeekOrigin.Begin);
                stream.Close();
            }
            var model = new FileData()
            {
                Id = SystemCommonMethod.GetGuid(),
                Data = data,
                Name = request.Name,
                FileFormat = request.FileFormat,
                PushFlag = false,
                DeleteFlag = false,
            };
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();
            reply.Id = model.Id;
            reply.FileFormat = model.FileFormat;
            reply.Name = model.Name;
            return reply;
        }

        public async Task<FileData> FindAsync(string id)
        {
            var model = await _context.FileDatas.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (model is null) return null;
            return model;
        }
    }
}
