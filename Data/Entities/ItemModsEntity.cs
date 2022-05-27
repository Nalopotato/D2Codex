using Domain.Models;

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
                return new ItemMods(); //TODO: Handle this
            }

            var itemMods = _context.ItemMods.FirstOrDefault(m => m.Id == id);

            if (itemMods == null)
            {
                return new ItemMods();
            }

            return itemMods;
        }

        public List<ItemMods> GetAll()
        {
            var itemMods = _context.ItemMods.ToList();

            return itemMods;
        }
    }
}
