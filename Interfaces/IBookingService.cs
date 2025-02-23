using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IBookingService
    {
        Booking GetById(int id);
        List<Booking> GetAll();
        Booking Add(Booking booking);

        public Booking Delete(int id);
        public Booking Update(Booking booking);
    }
}
