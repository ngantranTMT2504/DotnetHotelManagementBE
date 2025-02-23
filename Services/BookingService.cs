using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;

namespace HotelManagement.Services
{
    public class BookingService :IBookingService
    {
        private readonly HotelManagementDbContext _dbContext;

        public BookingService(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Booking Add(Booking booking)
        {
            try
            {
                _dbContext.Bookings.Add(booking);
                _dbContext.SaveChanges();
                return booking;
            } catch 
            {
                return null;
            }
        }

        public Booking Delete(int id)
        {
            try
            {
                var booking = _dbContext.Bookings.FirstOrDefault(x => x.Id == id);
                _dbContext.Bookings.Remove(booking);
                _dbContext.SaveChanges();
                return booking;
            } catch
            {
                return null;
            }
        }

        public List<Booking> GetAll()
        {
           try
            {
                var bookings = _dbContext.Bookings.ToList();
                return bookings;
            } catch { return null; }
        }

        public Booking GetById(int id)
        {
            try
            {
                var booking = _dbContext.Bookings.FirstOrDefault(x => x.Id==id);
                return booking;
            } catch { return null; }
        }

        public Booking Update(Booking _booking)
        {
            try
            {
                var booking = _dbContext.Bookings.FirstOrDefault(x => x.Id == _booking.Id);
                booking.DateCheckout = _booking.DateCheckout;
                booking.DateCheckin = _booking.DateCheckin;
                booking.TotalPrice = _booking.TotalPrice;
                booking.TotalRoom = _booking.TotalRoom;
                booking.Status = _booking.Status;
                _dbContext.Bookings.Update(booking);
                _dbContext.SaveChanges();
                return booking;
            } catch { return null; }
        }
    }
}
