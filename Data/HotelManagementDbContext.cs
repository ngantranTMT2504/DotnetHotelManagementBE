using System.Data;
using HotelManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Data
{
    public class HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options) : DbContext(options) 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingService>()
                .ToTable(nameof(BookingService), t => t.IsTemporal(false));

            modelBuilder.Entity<Service>()
                .ToTable(nameof(Service), t => t.IsTemporal(false))
                .HasMany(x => x.BookingServices)
                .WithOne(x => x.Service)
                .HasForeignKey(x => x.ServiceId)
                ;
        }


        public DbSet<BookingService> BookingServices { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
