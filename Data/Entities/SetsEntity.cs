using Domain.Models;

namespace Data.Entities
{
    public class SetsEntity
    {
        private readonly D2ItemsContext _context;

        public SetsEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public Sets Get(int? id)
        {
            if (id == null || _context.Sets == null)
            {
                return new Sets();
            }

            var sets = _context.Sets.FirstOrDefault(m => m.Id == id);

            if (sets == null)
            {
                return new Sets();
            }

            return sets;
        }

        public List<Sets> GetAll()
        {
            var sets = _context.Sets.ToList();

            return sets;
        }
    }
}
