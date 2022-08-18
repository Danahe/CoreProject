namespace CoreProject.DataModel
{
    public class MeasureData : CommonEntity
    {
        /// <summary>
        /// 文件
        /// </summary>
        public byte[] Data { get; set; }= Array.Empty<byte>();
        /// <summary>
        /// 文件格式
        /// </summary>
        public string FileFormat { get; set; } = "";
        /// <summary>
        /// 船舶id
        /// </summary>
        public string ShipId { get; set; } = "";
    }
}
