using D2Codex.Models;

namespace Data.Interfaces
{
    public interface IBaseTypesEntity
    {
        BaseTypes Get(int? id);
        List<BaseTypes> GetAll();
    }
}
