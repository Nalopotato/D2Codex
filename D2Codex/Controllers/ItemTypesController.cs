using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypesController : ControllerBase
    {
        private readonly IItemTypesEntity _itemTypesEntity;

        public ItemTypesController(IItemTypesEntity itemTypesEntity)
        {
            _itemTypesEntity = itemTypesEntity;
        }

        [HttpGet]
        public ItemTypes Get(int? id)
        {
            return _itemTypesEntity.Get(id);
        }

        [HttpGet]
        public List<ItemTypes> GetAll()
        {
            return _itemTypesEntity.GetAll();
        }
    }
}
