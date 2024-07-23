namespace MoiMovieStore.Domain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IList<Product>? Products { get; set; }
    }
}