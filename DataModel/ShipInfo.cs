namespace CoreProject.DataModel
{
    public class ShipInfo : CommonEntity
    {
        public string ShipCode { get; set; } = "";
        public string Name { get; set; } = "";
        public int Type { get; set; }
        public string TypeName { get; set; } = "";
        public string StatusName { get; set; } = "";
        public string Owner { get; set; } = "";
    }
}
