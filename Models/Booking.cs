﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public enum StatusBooking
    {
        Pending,
        Paid,
        Confirmed,
        Cancelled
    }

    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Payment Payment { get; set; }
        [Required]
        public int UserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
      
        [Required]
        public DateTime DateCheckin { get; set; }
        [Required]
        public DateTime DateCheckout { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public int TotalRoom { get; set; }
        [Required]
        public StatusBooking Status {  get; set; } = StatusBooking.Pending;

        public List<BookingService> BookingServices { get; set; }

        public List<RoomBooked> RoomBookeds { get; set; }

    }
}
