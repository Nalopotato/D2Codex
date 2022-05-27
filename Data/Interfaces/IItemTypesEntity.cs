using Domain.Models;

namespace Data.Interfaces
{
    public interface IItemTypesEntity
    {
        ItemTypes Get(int? id);
        List<ItemTypes> GetAll();
    }
}
