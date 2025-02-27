using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Models
{
    public class RegisterModel
    {
        [Required (ErrorMessage = "User Name is required")]
        public string? Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")] 
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Date Of Birth is required")]
        public DateOnly? DateOfBirth { get; set; }


    }
}
