namespace SecondTask.Models.Entities
{
    public class Canterbury : BaseEntity
    {
        public string Number { get; set; }
        public Warehouse Warehouse { get; set; }
        public decimal Capacity { get; set; }
    }
}
