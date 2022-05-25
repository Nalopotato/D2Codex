using D2Codex.Models;

namespace Data.Interfaces
{
    public interface ISkillsEntity
    {
        Skills Get(int? id);
        List<Skills> GetAll();
    }
}
