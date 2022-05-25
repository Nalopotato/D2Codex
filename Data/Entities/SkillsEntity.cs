using D2Codex.Models;

namespace Data.Entities
{
    public class SkillsEntity
    {
        private readonly D2ItemsContext _context;

        public SkillsEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public Skills Get(int? id)
        {
            if (id == null || _context.Skills == null)
            {
                return new Skills();
            }

            var skills = _context.Skills.FirstOrDefault(m => m.Id == id);

            if (skills == null)
            {
                return new Skills();
            }

            return skills;
        }

        public List<Skills> GetAll()
        {
            var skills = _context.Skills.ToList();

            return skills;
        }
    }
}
