namespace MoiMovieStore.Domain.Models
{
    public class OrderProduct
    {
        public Guid Id { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
    }
}