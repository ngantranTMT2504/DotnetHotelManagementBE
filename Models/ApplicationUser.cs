using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Models
{
 
    public class ApplicationUser: IdentityUser
    {
        public DateOnly DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string? Address { get; set; }
        public String? FullName { get; set; }
        public DateOnly DateCreated { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);  
        [Required]
        public string Role { get; set; } = UserRoles.User;

        public List<Booking> Booking { get; set; }
    }
}
