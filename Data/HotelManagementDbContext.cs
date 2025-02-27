using System.Data;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace HotelManagement.Data
{
    public class HotelManagementDbContext: IdentityDbContext<ApplicationUser>
    {

        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options): base(options)
        { 
        }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeRoom>()
                .ToTable(nameof(TypeRoom), t => t.IsTemporal(false))
                .HasMany(x => x.Room)
                .WithOne(x => x.TypeRoom)
                .HasForeignKey(x => x.TypeRoomId);

            modelBuilder.Entity<Room>()
                .ToTable(nameof(Room), t => t.IsTemporal(false))
                .HasMany(x => x.RoomBookeds)
                .WithOne(x => x.Room)
                .HasForeignKey(x => x.RoomId);

            modelBuilder.Entity<RoomBooked>()
                .ToTable(nameof(RoomBooked), t => t.IsTemporal(false));

            modelBuilder.Entity<Payment>()
                .ToTable(nameof(Payment), t => t.IsTemporal(false));
                

            modelBuilder.Entity<Booking>()
                .ToTable(nameof(Booking), t => t.IsTemporal(false))
                .HasMany(x => x.BookingServices)
                .WithOne(x => x.Booking)
                .HasForeignKey(x => x.BookingId);
            modelBuilder.Entity<Booking>()
                .HasMany(x => x.RoomBookeds)
                .WithOne(x => x.Booking)
                .HasForeignKey(x => x.BookingId);
            modelBuilder.Entity<Booking>()
                .HasOne(x => x.Payment)
                .WithOne(x => x.Booking)
                .HasForeignKey<Payment>(x => x.BookingId);
            
                

            modelBuilder.Entity<BookingService>()
                .ToTable(nameof(BookingService), t => t.IsTemporal(false));
                

            modelBuilder.Entity<Service>()
                .ToTable(nameof(Service), t => t.IsTemporal(false))
                .HasMany(x => x.BookingServices)
                .WithOne(x => x.Service)
                .HasForeignKey(x => x.ServiceId);

            modelBuilder.Entity<IdentityRole<string>>().ToTable("Role").HasNoKey();
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim").HasNoKey();
            modelBuilder.Entity<IdentityUser<string>>().ToTable("User").HasKey(b => b.Id);
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim").HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserToken").HasNoKey();
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin").HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRole").HasNoKey();

        }


        public DbSet<BookingService> BookingServices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBooked> RoomsBookeds { get; set; }
        public DbSet<TypeRoom> TypeRooms { get; set; }
        


    }
}
