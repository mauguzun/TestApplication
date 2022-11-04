using Microsoft.AspNetCore.Mvc;
using SecondTask.Models.Dto;
using SecondTask.Models.Entities;
using SecondTask.Services.Interfaces;

namespace SecondTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService) => _itemService = itemService;
     

        [HttpPost]
        public ItemState InsertItem(InsertItem arg) => _itemService.InsertItem(arg);
      
    }
}