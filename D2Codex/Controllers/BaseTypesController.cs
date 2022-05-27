using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/BaseTypes")]
    [ApiController]
    public class BaseTypesController : ControllerBase
    {
        private readonly IBaseTypesEntity _baseTypesEntity;

        public BaseTypesController(IBaseTypesEntity baseTypesEntity)
        {
            _baseTypesEntity = baseTypesEntity;
        }

        [HttpGet("{id}")]
        public BaseTypes Get(int? id)
        {
            return _baseTypesEntity.Get(id);
        }

        [HttpGet]
        public List<BaseTypes> GetAll()
        {
            return _baseTypesEntity.GetAll();
        }
    }
}
