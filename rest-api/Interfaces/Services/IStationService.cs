using rest_api.Models;

namespace rest_api.Interfaces.Services
{
    public interface IStationService : IBaseService<Station>
    {
        Task Add(Station station, int areaId);
    }
}
