using Microsoft.AspNetCore.Identity;

namespace MoiMovieStore.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;
        public Address? Address { get; set; }
    }
}