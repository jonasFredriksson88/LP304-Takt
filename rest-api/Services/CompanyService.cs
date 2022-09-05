using rest_api.Interfaces.Repositories;
using rest_api.Interfaces.Services;
using rest_api.models;
using rest_api.Models;

namespace rest_api.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task Add(Company company)
        {
            await _companyRepository.Add(company);
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Company>> GetEntities()
        {
            return await _companyRepository.GetEntities();
        }

        public async Task<Company> GetEntity(int id)
        {
            return await _companyRepository.GetEntity(id);
        }

        public async Task<ICollection<User>> GetUserByCompany(int companyId)
        {
            return await _companyRepository.GetUserByCompany(companyId);
        }
    }
}
