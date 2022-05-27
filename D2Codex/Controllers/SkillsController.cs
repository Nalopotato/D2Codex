using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Data.Interfaces;

namespace D2Codex.Controllers
{
    [Route("api/Skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillsEntity _skillsEntity;

        public SkillsController(ISkillsEntity skillsEntity)
        {
            _skillsEntity = skillsEntity;
        }

        [HttpGet("{id}")]
        public Skills Get(int? id)
        {
            return _skillsEntity.Get(id);
        }

        [HttpGet]
        public List<Skills> GetAll()
        {
            return _skillsEntity.GetAll();
        }
    }
}
