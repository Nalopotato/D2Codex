using Domain.Models;

namespace Data.Interfaces
{
    public interface IBaseTypesEntity
    {
        BaseTypes Get(int? id);
        List<BaseTypes> GetAll();
    }
}
