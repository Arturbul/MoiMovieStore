namespace MoiMovieStore.Domain.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IList<Storage>? Storages { get; set; }
        public IList<Order>? Orders { get; set; }
    }
}
