using rest_api.Models;

namespace rest_api.Interfaces.Repositories
{
    public interface IAreaRepository : IBaseRepository<Area>
    {
        Task Add(Area area, int companyId);
    }
}
