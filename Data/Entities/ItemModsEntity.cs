using D2Codex.Models;

namespace Data.Entities
{
    public class ItemModsEntity
    {
        private readonly D2ItemsContext _context;

        public ItemModsEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public ItemMods Get(int? id)
        {
            if (id == null || _context.ItemMods == null)
            {
                return new ItemMods();
            }

            var itemMods = _context.ItemMods
                .Include(i => i.Item)
                .Include(i => i.Mod)
                .FirstOrDefault(m => m.Id == id);

            if (itemMods == null)
            {
                return new ItemMods();
            }

            return itemMods;
        }

        public List<ItemMods> GetAll()
        {
            var itemMods = _context.ItemMods
                .Include(i => i.Item)
                .Include(i => i.Mod)
                .ToList();

            return itemMods;
        }
    }
}
