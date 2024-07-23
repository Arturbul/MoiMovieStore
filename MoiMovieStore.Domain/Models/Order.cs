namespace MoiMovieStore.Domain.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int ShopId { get; set; }
        public IList<OrderProduct>? OrderProducts { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Customer Customer { get; set; } = null!;
        public Address DeliveryAddress { get; set; } = null!;
        public double TotalPriceBrutto { get; set; }
        public double TotalPriceNetto { get; set; }
    }
}
