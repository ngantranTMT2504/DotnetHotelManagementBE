﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int Price { get; set; }

        public string ImageService {  get; set; }
        public List<BookingService> BookingServices { get; set; }

    }
}
