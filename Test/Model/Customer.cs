namespace Test.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CustomerApplication> CustomerApplications { get; set; }
    }
}
