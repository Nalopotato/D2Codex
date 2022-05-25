using D2Codex.Models;

namespace Data.Interfaces
{
    public interface ISubTypesEntity
    {
        SubTypes Get(int? id);
        List<SubTypes> GetAll();
    }
}
