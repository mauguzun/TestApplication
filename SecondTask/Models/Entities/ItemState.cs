namespace SecondTask.Models.Entities
{
    public class ItemState : BaseEntity
    {
        public Item Item { get; set; }
        public Canterbury Canterbury { get; set; }
        public decimal Quantity { get; set; }
        public ItemPack ItemPack { get; set; }

    }


}
