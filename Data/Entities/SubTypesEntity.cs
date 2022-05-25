using D2Codex.Models;

namespace Data.Entities
{
    public class SubTypesEntity
    {
        private readonly D2ItemsContext _context;

        public SubTypesEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public SubTypes Get(int? id)
        {
            if (id == null || _context.SubTypes == null)
            {
                return new SubTypes();
            }

            var subTypes = _context.SubTypes.FirstOrDefault(m => m.Id == id);

            if (subTypes == null)
            {
                return new SubTypes();
            }

            return subTypes;
        }

        public List<SubTypes> GetAll()
        {
            var subTypes = _context.SubTypes.ToList();

            return subTypes;
        }
    }
}
