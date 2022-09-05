using rest_api.Models;

namespace rest_api.Interfaces.Repositories
{
    public interface IStationRepository : IBaseRepository<Station>
    {
        Task Add(Station station, int areaId);
    }
}
