namespace CoreProject.DataModel
{
    public class FileData : CommonEntity
    {
        public byte[] Data { get; set; }= new byte[0];
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
