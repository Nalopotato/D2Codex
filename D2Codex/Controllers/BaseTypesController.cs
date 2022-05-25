using D2Codex.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseTypesController : ControllerBase
    {
        private readonly IBaseTypesEntity _baseTypesEntity;

        public BaseTypesController(IBaseTypesEntity baseTypesEntity)
        {
            _baseTypesEntity = baseTypesEntity;
        }

        [HttpGet]
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
