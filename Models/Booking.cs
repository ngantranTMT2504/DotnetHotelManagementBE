using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum StatusBooking
    {
        Pending,
        Confirmed,
        Cancelled
    }

    public class Booking
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public DateOnly DateCkeckin { get; set; }
        [Required]
        public DateOnly DateCheckout { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public int TotalRoom { get; set; }
        [Required]
        public StatusBooking Status {  get; set; } = StatusBooking.Pending;

    }
}
