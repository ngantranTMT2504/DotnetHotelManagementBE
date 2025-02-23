using HotelManagement.Data;
using HotelManagement.Interfaces;

namespace HotelManagement.Services
{
    public class BookingServicesService : IBookingServicesService
    {
        private readonly HotelManagementDbContext _dbContext;

        public BookingServicesService(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.BookingService Add(Models.BookingService bookingService)
        {
            try
            {
                _dbContext.BookingServices.Add(bookingService);
                _dbContext.SaveChanges();
                return bookingService;
            } catch
            {
                return null;
            }
        }

        public Models.BookingService Delete(int id)
        {
            try
            {
                var bookingService = _dbContext.BookingServices.FirstOrDefault(x => x.ID == id);
                _dbContext.BookingServices.Remove(bookingService);
                _dbContext.SaveChanges();
                return bookingService;
            } catch
            {
                return null;
            }
        }

        public List<Models.BookingService> GetAll()
        {
            try
            {
                var bookingServices = _dbContext.BookingServices.ToList();
                return bookingServices;
            }
            catch
            {
                return null;
            }
        }

        public Models.BookingService GetById(int id)
        {
            try
            {
                var bookingService = _dbContext.BookingServices.FirstOrDefault(x => x.ID==id);
                return bookingService;
            } catch
            {
                return null;
            }
        }

        public Models.BookingService Update(Models.BookingService _bookingService)
        {
            try
            {
                var bookingService = _dbContext.BookingServices.FirstOrDefault(x => x.ID == _bookingService.ID);
                bookingService.ID = _bookingService.ID;
                bookingService.TotalPrice = _bookingService.TotalPrice;
                bookingService.Quantity = _bookingService.Quantity;

                _dbContext.BookingServices.Update(bookingService);
                _dbContext.SaveChanges();
                return bookingService;
            } catch
            {
                return null;
            }
        }
    }
}
