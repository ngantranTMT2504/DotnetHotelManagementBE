using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class TypeRoom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        [Range(1, 5)]
        public int Capacity { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
