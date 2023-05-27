
namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public Address()
        {
            Id = -1;
            Name = string.Empty;
            Line1 = string.Empty;
            Line2 = string.Empty;
            City = string.Empty;
            Region = string.Empty;
            PostalCode = string.Empty;
        }
    }
}
