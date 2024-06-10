using System.Data;

namespace Test.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<CustomerApplication> CustomerApplications { get; set; }
    }
}
