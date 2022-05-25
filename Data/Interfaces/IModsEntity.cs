using D2Codex.Models;

namespace Data.Interfaces
{
    public interface IModsEntity
    {
        Mods Get(int? id);
        List<Mods> GetAll();
    }
}
