using rest_api.Interfaces.Repositories;
using rest_api.Interfaces.Services;
using rest_api.models;
using rest_api.Models;

namespace rest_api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Add(User user, int companyId)
        {
            await _userRepository.Add(user, companyId);
        }

        public async Task<ICollection<User>> GetEntities()
        {
            return await _userRepository.GetEntities();
        }

        public async Task<User> GetEntity(int id)
        {
            return await _userRepository.GetEntity(id);
        }

        public async Task<Company> GetCompanyByUser(int userId)
        {
            return await _userRepository.GetCompanyByUser(userId);
        }

        public Task DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}
