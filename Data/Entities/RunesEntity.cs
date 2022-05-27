using Domain.Models;

namespace Data.Entities
{
    public class RunesEntity
    {
        private readonly D2ItemsContext _context;

        public RunesEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public Runes Get(int? id)
        {
            if (id == null || _context.Runes == null)
            {
                return new Runes();
            }

            var runes = _context.Runes.FirstOrDefault(m => m.Id == id);

            if (runes == null)
            {
                return new Runes();
            }

            return runes;
        }

        public List<Runes> GetAll()
        {
            var runes = _context.Runes.ToList();

            return runes;
        }
    }
}
