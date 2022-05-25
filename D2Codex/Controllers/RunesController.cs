using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunesController : ControllerBase
    {
        private readonly IRunesEntity _runesEntity;

        public RunesController(IRunesEntity runesEntity)
        {
            _runesEntity = runesEntity;
        }

        [HttpGet]
        public Runes Get(int? id)
        {
            return _runesEntity.Get(id);
        }

        [HttpGet]
        public List<Runes> GetAll()
        {
            return _runesEntity.GetAll();
        }
    }
}
