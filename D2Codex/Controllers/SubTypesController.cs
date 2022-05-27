using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTypesController : ControllerBase
    {
        private readonly ISubTypesEntity _subTypesEntity;

        public SubTypesController(ISubTypesEntity subTypesEntity)
        {
            _subTypesEntity = subTypesEntity;
        }

        [HttpGet]
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
