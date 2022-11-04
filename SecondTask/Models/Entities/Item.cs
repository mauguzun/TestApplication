namespace SecondTask.Models.Entities
{
    public class Item : BaseEntity
    {
        public string UniqueCode { get; set; }
        public string Category { get; set; } //  of coz must be separed table , not have any time
        public string Title { get; set; }
    }


}
