using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class Room
    {
        public enum StatusRoom
        {
            Available,
            Occupied,
            Maintenance,
            NeedsCleaning
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string NumberRoom { get; set; }
        [Required]
        public int TypeRoom { get; set; }
        public string? ImageRoom { get; set; }
        [Required]
        public StatusRoom Status {  get; set; } = StatusRoom.Available;

    }
}
