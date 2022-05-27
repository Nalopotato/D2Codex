using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/Sets")]
    [ApiController]
    public class SetsController : ControllerBase
    {
        private readonly ISetsEntity _setsEntity;

        public SetsController(ISetsEntity setsEntity)
        {
            _setsEntity = setsEntity;
        }

        [HttpGet("{id}")]
        public Sets Get(int? id)
        {
            return _setsEntity.Get(id);
        }

        [HttpGet]
        public List<Sets> GetAll()
        {
            return _setsEntity.GetAll();
        }
    }
}
