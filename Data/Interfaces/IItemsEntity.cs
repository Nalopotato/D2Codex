using D2Codex.Models;

namespace Data.Interfaces
{
    public interface IItemsEntity
    {
        Items Get(int? id);
        List<Items> GetAll();
    }
}
