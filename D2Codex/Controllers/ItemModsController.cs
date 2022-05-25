﻿using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemModsController : ControllerBase
    {
        private readonly IItemModsEntity _itemModsEntity;

        public ItemModsController(IItemModsEntity itemModsEntity)
        {
            _itemModsEntity = itemModsEntity;
        }

        [HttpGet]
        public ItemMods Get(int? id)
        {
            return _itemModsEntity.Get(id);
        }

        [HttpGet]
        public List<ItemMods> GetAll()
        {
            return _itemModsEntity.GetAll();
        }
    }
}
