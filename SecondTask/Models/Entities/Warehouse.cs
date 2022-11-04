namespace SecondTask.Models.Entities
{
    public class Warehouse : BaseEntity
    {
        public string Number { get; set; }         //string for num like 11-1
        public decimal Capacity { get; set; }
        public List<Canterbury> Canterburies { get; set; }
    }


}
