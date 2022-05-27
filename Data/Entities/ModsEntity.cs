using Domain.Models;

namespace Data.Entities
{
    public class ModsEntity
    {
        private readonly D2ItemsContext _context;

        public ModsEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public Mods Get(int? id)
        {
            if (id == null || _context.Mods == null)
            {
                return new Mods();
            }

            var mods = _context.Mods.FirstOrDefault(m => m.Id == id);

            if (mods == null)
            {
                return new Mods();
            }

            return mods;
        }

        public List<Mods> GetAll()
        {
            var mods = _context.Mods.ToList();

            return mods;
        }
    }
}
