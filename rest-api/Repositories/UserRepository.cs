using Microsoft.EntityFrameworkCore;
using rest_api.Data;
using rest_api.Interfaces.Repositories;
using rest_api.models;
using rest_api.Models;

namespace rest_api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(User user, int companyId)
        {
            var company = await _context.Companies.FindAsync(companyId);

            if (company != null)
            {
                user.CompanyId = companyId;
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> GetEntity(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<ICollection<User>> GetEntities()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<Company> GetCompanyByUser(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            return user.Company;
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
