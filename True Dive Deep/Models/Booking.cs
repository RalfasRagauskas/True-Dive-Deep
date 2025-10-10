using System.ComponentModel.DataAnnotations;

namespace True_Dive_Deep.Models
{
    public class Booking
    {
        [Key]
        public Guid BookingId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        // Liste over varer fra kurven
        public List<CartItem> Items { get; set; } = new List<CartItem>();//////

        //[Required]
        //[Display(Name = "Account")]
        //public int AccountId { get; set; }
        //public Account Account { get; set; } = null!;

        //[Timestamp]
        //public byte[]? Rowversion { get; set; }

    }
}
