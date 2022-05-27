using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/SubTypes")]
    [ApiController]
    public class SubTypesController : ControllerBase
    {
        private readonly ISubTypesEntity _subTypesEntity;

        public SubTypesController(ISubTypesEntity subTypesEntity)
        {
            _subTypesEntity = subTypesEntity;
        }

        [HttpGet("{id}")]
        public SubTypes Get(int? id)
        {
            return _subTypesEntity.Get(id);
        }

        [HttpGet]
        public List<SubTypes> GetAll()
        {
            return _subTypesEntity.GetAll();
        }
    }
}
