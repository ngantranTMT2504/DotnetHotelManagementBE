using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HotelManagement.Models
{
    public class TypeRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [JsonIgnore]
        public List<Room> Room { get; set; }

    }
}
