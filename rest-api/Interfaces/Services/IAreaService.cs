using rest_api.Models;

namespace rest_api.Interfaces.Services
{
    public interface IAreaService : IBaseService<Area>
    {
        Task Add(Area area, int companyId);
    }
}
