namespace SecondTask.Models.Entities
{
    public class CanterburyLog : BaseEntity
    {
        public Canterbury Canterbury { get; set; }
        public Item Item { get; set; }
        public CanterburyLogType CanterburyLogType { get; set; }
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }

    }


}
