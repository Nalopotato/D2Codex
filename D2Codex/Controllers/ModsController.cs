using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/Mods")]
    [ApiController]
    public class ModsController : ControllerBase
    {
        private readonly IModsEntity _modsEntity;

        public ModsController(IModsEntity modsEntity)
        {
            _modsEntity = modsEntity;
        }

        [HttpGet("{id}")]
        public Mods Get(int? id)
        {
            return _modsEntity.Get(id);
        }

        [HttpGet]
        public List<Mods> GetAll()
        {
            return _modsEntity.GetAll();
        }
    }
}
