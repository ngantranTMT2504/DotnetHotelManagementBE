using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        BankTransfer,
        Online
    }
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BookingId { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateOnly PaymentDate { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
        [Required]
        public PaymentMethod Method { get; set; } = PaymentMethod.Online;
        [Required]
        [Range(0, 100)]
        public decimal UpFrontPayment { get; set; } 
    }
}
