using D2Codex.Models;

namespace Data.Interfaces
{
    public interface IItemModsEntity
    {
        ItemMods Get(int? id);
        List<ItemMods> GetAll();
    }
}
