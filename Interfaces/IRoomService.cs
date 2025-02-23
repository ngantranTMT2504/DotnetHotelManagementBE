using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IRoomService
    {
        Room GetById(int id);
        List<Room> GetAll();
        Room Add(Room room);

        public Room Delete(int id);
        public Room Update( Room room);

    }
}
