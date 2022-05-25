using D2Codex.Models;

namespace Data.Interfaces
{
    public interface ISetsEntity
    {
        Sets Get(int? id);
        List<Sets> GetAll();
    }
}
