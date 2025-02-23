using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IBookingServicesService
    {
        BookingService GetById(int id);
        List<BookingService> GetAll();
        BookingService Add(BookingService bookingService);

        BookingService Delete(int id);
        BookingService Update(BookingService bookingService);
    }
}
