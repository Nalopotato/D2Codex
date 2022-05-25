using D2Codex.Models;

namespace Data.Entities
{
    public class ItemsEntity
    {
        private readonly D2ItemsContext _context;

        public ItemsEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public Items Get(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return new Items();
            }

            var items = _context.Items.FirstOrDefault(m => m.Id == id);

            if (items == null)
            {
                return new Items();
            }

            return items;
        }

        public List<Items> GetAll()
        {
            var items = _context.Items.ToList();

            return items;
        }
    }
}
