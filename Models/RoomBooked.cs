using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public class RoomBooked
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public DateOnly DateBooked { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
