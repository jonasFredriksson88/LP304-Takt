using rest_api.models;
using rest_api.Models;

namespace rest_api.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task Add(User user, int companyId);
        Task<Company> GetCompanyByUser(int userId);
    }
}
