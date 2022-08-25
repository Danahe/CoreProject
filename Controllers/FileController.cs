using CoreProject.DataModel;
using CoreProject.DtoModel;
using CoreProject.IService;
using CoreProject.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreProject.CommonMethod;
using MimeMapping;

namespace CoreProject.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : Controller
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> UploadAsync([FromForm] FileUploadRequest request)
        {
            if (request.Data is null) return Ok(Result.Fail("未找到数据"));
            var res = await _fileService.FileUpload(request);
            return Ok(new APIResult<FileUploadReply>(res));
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("download")]
        public async Task<IActionResult> DownLoadAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return Ok(Result.Fail("参数不能为空"));
            var model = await _fileService.FindAsync(id);
            if (model is null) return Ok(Result.Fail("未找到文件"));
            return File(model.Data, MimeUtility.GetMimeMapping(model.FileFormat), model.Name);
        }

        [HttpPost]
        [Route("upload-files")]
        public async Task<IActionResult> UploadFilesAsync(List<IFormFile> files)
        {
            var res = await _fileService.FilesUploadAsync(files);
            return Ok(res);
        }
    }
}
