using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModsController : ControllerBase
    {
        private readonly IModsEntity _modsEntity;

        public ModsController(IModsEntity modsEntity)
        {
            _modsEntity = modsEntity;
        }

        [HttpGet]
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
