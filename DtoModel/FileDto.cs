using Microsoft.AspNetCore.Http;

namespace CoreProject.DtoModel
{
    public class FileUploadReply
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        /// <summary>
        /// 文件格式
        /// </summary>
        public string FileFormat { get; set; } = "";
    }

    public class FileUploadRequest
    {
        public string Id { get; set; } = "";
        /// <summary>
        /// 文件
        /// </summary>
        public IFormFile Data { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// 文件格式
        /// </summary>
        public string FileFormat { get; set; } = "";
    }
}
