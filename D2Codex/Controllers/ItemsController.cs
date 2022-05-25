using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsEntity _itemsEntity;

        public ItemsController(IItemsEntity itemsEntity)
        {
            _itemsEntity = itemsEntity;
        }

        [HttpGet]
        public Items Get(int? id)
        {
            return _itemsEntity.Get(id);
        }

        [HttpGet]
        public List<Items> GetAll()
        {
            return _itemsEntity.GetAll();
        }
    }
}
