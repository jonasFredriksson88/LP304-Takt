using rest_api.Data;
using rest_api.Interfaces.Repositories;
using rest_api.Models;

namespace rest_api.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly DataContext _context;
public StationRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task Add(Station station, int areaId)
        {
            var area = await _context.Areas.FindAsync(areaId);

            if (area != null)
            {
                station.AreaId = areaId;
                await _context.Stations.AddAsync(station);
                await _context.SaveChangesAsync();
            }
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Station>> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Task<Station> GetEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
