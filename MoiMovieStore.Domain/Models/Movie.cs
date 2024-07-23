namespace MoiMovieStore.Domain.Models
{
    public class Movie : Product
    {
        public Genre Genre { get; set; } = null!;
        public MPA? MPA { get; set; }
        public DateOnly Premiere { get; set; }
        public string Director { get; set; } = null!;
        public int Duration { get; set; }
        public double Raiting { get; set; }
    }
}
