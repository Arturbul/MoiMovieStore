using System.ComponentModel.DataAnnotations.Schema;

namespace MoiMovieStore.Domain.Models
{
    public class PriceDetails
    {
        public double ReguralPrice { get; set; }
        public double NettoPrice { get; set; }
        public double VAT { get; set; }
        [NotMapped]
        public double BruttoPrice => NettoPrice * (1 + VAT / 100);
    }
}