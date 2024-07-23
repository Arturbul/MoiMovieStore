
namespace MoiMovieStore.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public PriceDetails PriceDetails { get; set; } = null!;
        public bool IsAvilable { get; private set; }
        public string Manufacturer { get; set; } = null!;
        public string SKU { get; set; } = null!;
    }
}