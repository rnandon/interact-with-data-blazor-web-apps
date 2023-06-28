using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a name longer than 3 letters."), MaxLength(100, ErrorMessage = "Please use a name shorter than 100 letters.")]
        public string Name { get; set; }

        [Required, MinLength(5, ErrorMessage = "Please use a street address longer than 5 characters."), MaxLength(100, ErrorMessage = "Please use a street address shorter than 100 characters.")]
        public string Line1 { get; set; }

        [MaxLength(100, ErrorMessage = "Please use a street address shorter than 100 characters.")]
        public string Line2 { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a city name longer than 3 characters."), MaxLength(50, ErrorMessage = "Please use a city name shorter than 50 characters.")]
        public string City { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a state name greater than 3 characters."), MaxLength(20, ErrorMessage = "Please use a state name shorter than 20 characters.")]
        public string Region { get; set; }

        [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Zip code should be 5 consecutive numbers, with no letters.")]
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
