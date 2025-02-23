using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string NumberRoom { get; set; }
        
        public string ImageRoom { get; set; }
        [Required]
        public StatusRoom Status {  get; set; } = StatusRoom.Available;

        public int TypeRoomId { get; set; }
        public TypeRoom TypeRoom {  get; set; }
        public List<RoomBooked> RoomBookeds { get; set; }
        
    }
}
