using D2Codex.Models;

namespace Data.Interfaces
{
    public interface IRunesEntity
    {
        Runes Get(int? id);
        List<Runes> GetAll();
    }
}
