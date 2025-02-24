using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HotelManagement.Models
{
    public enum UserRole
    {
        Admin,
        User
    }
    public class User: IdentityUser
    {
        
        public DateOnly? DateOfBirth { get; set; }

        public bool Gender { get; set; }
        public string? Address { get; set; }
        public DateOnly DateCreated { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);  
        [Required]
        public UserRole Role { get; set; } = UserRole.User;
    }
}
