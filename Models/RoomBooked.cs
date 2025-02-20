using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public class RoomBooked
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomId {  get; set; }
        [Required]
        public DateOnly DateBooked { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
    }
}
