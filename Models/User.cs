using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public enum UserRole
    {
        Admin,
        User
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PasswordHash { get; set; } =  string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public DateOnly? DateOfBirth { get; set; }

        public bool Gender { get; set; } // true = Male, false = Female
        public string? Address { get; set; }
        public DateOnly DateCreated { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);  
        [Required]
        public UserRole Role { get; set; } = UserRole.User;
        public bool Status { get; set; } = true; // true = Active, false = Inactive


    }
}
