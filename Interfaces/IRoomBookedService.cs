using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IRoomBookedService
    {
        RoomBooked GetById(int id);
        List<RoomBooked> GetAll();
        RoomBooked Add(RoomBooked roomBooked);

        public RoomBooked Delete(int id);
        public RoomBooked Update( RoomBooked roomBooked);
    }
}
