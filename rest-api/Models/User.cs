using rest_api.Models;

namespace rest_api.models
{
    public class User
    {
        public int Id { get; set; } 
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
