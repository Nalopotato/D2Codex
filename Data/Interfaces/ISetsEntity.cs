using Domain.Models;

namespace Data.Interfaces
{
    public interface ISetsEntity
    {
        Sets Get(int? id);
        List<Sets> GetAll();
    }
}
