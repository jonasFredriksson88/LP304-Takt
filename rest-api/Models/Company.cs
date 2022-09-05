using rest_api.models;

namespace rest_api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Area> Areas { get; set; }
    }
}
