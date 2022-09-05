using rest_api.models;
using rest_api.Models;

namespace rest_api.Interfaces.Services
{
    public interface ICompanyService : IBaseService<Company>
    {
        Task<ICollection<User>> GetUserByCompany(int companyId);
        Task Add(Company company);
    }
}
