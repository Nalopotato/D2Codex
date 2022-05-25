using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetsController : ControllerBase
    {
        private readonly ISetsEntity _setsEntity;

        public SetsController(ISetsEntity setsEntity)
        {
            _setsEntity = setsEntity;
        }

        [HttpGet]
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
