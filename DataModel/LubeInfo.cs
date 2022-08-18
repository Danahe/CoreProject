namespace CoreProject.DataModel
{
    public class LubeInfo : CommonEntity
    {
        /// <summary>
        /// 油品种类
        /// </summary>
        public string Type { get; set; } = "";
        /// <summary>
        /// 油品牌号
        /// </summary>
        public string No { get; set; } = "";
        /// <summary>
        /// 规格型号
        /// </summary>
        public double Model { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; } = "";
        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; } = "";
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; } = "";
    }
}
