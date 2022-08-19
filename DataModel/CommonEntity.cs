namespace CoreProject.DataModel
{
    public class CommonEntity
    {
        public string Id { get; set; } = "";
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifyDate { get; set; } = DateTime.Now;
        public bool DeleteFlag { get; set; } = false;
        public bool PushFlag { get; set; } = false;
    }
}
