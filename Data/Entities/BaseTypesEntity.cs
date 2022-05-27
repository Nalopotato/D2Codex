using Domain.Models;

namespace Data.Entities
{
    public class BaseTypesEntity
    {
        private readonly D2ItemsContext _context;

        public BaseTypesEntity(D2ItemsContext context)
        {
            _context = context;
        }

        public BaseTypes Get(int? id)
        {
            if (id == null || _context.BaseTypes == null)
            {
                return new BaseTypes();
            }

            var baseTypes = _context.BaseTypes.FirstOrDefault(m => m.Id == id);

            if (baseTypes == null)
            {
                return new BaseTypes();
            }

            return baseTypes;
        }

        public List<BaseTypes> GetAll()
        {
            var baseTypes = _context.BaseTypes.ToList();

            return baseTypes;
        }
    }
}
