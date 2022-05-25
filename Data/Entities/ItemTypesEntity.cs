using D2Codex.Models;

namespace Data.Entities
{
    public class ItemTypesEntity
    {
        private readonly D2ItemsContext _context;

        public ItemTypesEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public ItemTypes Get(int? id)
        {
            if (id == null || _context.ItemTypes == null)
            {
                return new ItemTypes();
            }

            var itemTypes = _context.ItemTypes.FirstOrDefault(m => m.Id == id);

            if (itemTypes == null)
            {
                return new ItemTypes();
            }

            return itemTypes;
        }

        public List<ItemTypes> GetAll()
        {
            var itemTypes = _context.ItemTypes.ToList();

            return itemTypes;
        }
    }
}
