namespace MoiMovieStore.Domain.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IList<Product>? Products { get; set; }
    }
}
