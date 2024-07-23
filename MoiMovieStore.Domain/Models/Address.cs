namespace MoiMovieStore.Domain.Models
{
    public class Address
    {
        public string Street { get; set; } = null!;
        public string City { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string State { get; set; } = null!;

    }
}