using System.ComponentModel.DataAnnotations;

namespace True_Dive_Deep.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Required]
        
        public string? Title { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        [Display(Name = "Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;

        [Timestamp]
        public byte[]? Rowversion { get; set; }

    }
}
