namespace Faker.Test.TestClasses
{
    public class CustomGenerator
    {
        public string City { get; set; }
        public string Name { get; }
        
        public string RandomString { get; set; }

        public CustomGenerator(string name)
        {
            Name = name;
        }
    }
}