using rest_api.Interfaces.Repositories;
using rest_api.Interfaces.Services;
using rest_api.Models;

namespace rest_api.Services
{
    public class AreaService : IAreaService
    {
        private readonly IAreaRepository _areaRepository;

        public AreaService(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }

        public async Task Add(Area area, int companyId)
        {
            await _areaRepository.Add(area, companyId);
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Area>> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Task<Area> GetEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
