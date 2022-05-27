using Domain.Models;

namespace Data.Interfaces
{
    public interface IItemsEntity
    {
        Items Get(int? id);
        List<Items> GetAll();
    }
}
