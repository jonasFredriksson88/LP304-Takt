using Microsoft.EntityFrameworkCore;
using rest_api.Data;
using rest_api.Interfaces.Repositories;
using rest_api.models;
using rest_api.Models;

namespace rest_api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;

        public CompanyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(Company company)
        {
            await _context.Companies.AddAsync(company);

            await _context.SaveChangesAsync();
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Company>> GetEntities()
        {
            return await _context.Companies
                .Include(c => c.Users)
                .Include(c => c.Areas)
                .ThenInclude(a => a.Stations)
                .ToListAsync();
        }

        public async Task<Company> GetEntity(int id)
        {
            return await _context.Companies.FindAsync(id);
        }

        public async Task<ICollection<User>> GetUserByCompany(int companyId)
        {
            return await _context.Users.Where(u => u.CompanyId == companyId).ToListAsync();
        }
    }
}
