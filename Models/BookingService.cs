using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public class BookingService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

    }
}
