using SecondTask.Models.Dto;
using SecondTask.Models.Entities;

namespace SecondTask.Services.Interfaces
{
    public interface IItemService
    {
        public ItemState InsertItem(InsertItem items);
        public ItemState RemoveItem(RemoveItem items);

    }
}
