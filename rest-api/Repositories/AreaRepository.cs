using rest_api.Data;
using rest_api.Interfaces.Repositories;
using rest_api.Models;

namespace rest_api.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly DataContext _context;

        public AreaRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Area area, int companyId)
        {
            var company = await _context.Companies.FindAsync(companyId);

            if (company != null)
            {
                area.CompanyId = companyId;
                await _context.Areas.AddAsync(area);
                await _context.SaveChangesAsync();
            }
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
