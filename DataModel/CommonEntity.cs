namespace CoreProject.DataModel
{
    public class CommonEntity
    {
        public string Id { get; set; } = "";
        public DateTime CreatDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool DeleteFlag { get; set; }
        public bool PushFlag { get; set; }
    }
}
