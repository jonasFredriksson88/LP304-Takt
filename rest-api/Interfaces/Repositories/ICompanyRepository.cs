using rest_api.models;
using rest_api.Models;

namespace rest_api.Interfaces.Repositories
{
    public interface ICompanyRepository : IBaseRepository<Company>
    {
        Task Add(Company company);
        Task<ICollection<User>> GetUserByCompany(int companyId);
    }
}
