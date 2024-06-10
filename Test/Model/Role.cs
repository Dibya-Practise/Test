namespace Test.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
    }
}
