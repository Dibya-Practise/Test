namespace Test.Model
{
    public class CustomerApplication
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
