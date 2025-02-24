using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Services
{
    public class RoomService: IRoomService
    {
        private readonly HotelManagementDbContext _dbContext;

        public RoomService(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Room GetById(int id)
        {
            try
            {
            var room = _dbContext.Rooms
               .Include(x => x.RoomBookeds)
               .FirstOrDefault(x => x.Id == id);

                return room;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public List<Room> GetAll()
        {
            try
            {
                var rooms = _dbContext.Rooms
                    .Include(rm => rm.TypeRoom).ToList();
                return rooms;
            }
            catch (Exception ex) {
                throw;
            }
        }

        public Room Add(Room room)
        {
            try
            {
                _dbContext.Rooms.Add(room);
                _dbContext.SaveChanges();
                return room;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Room Delete(int id)
        {
            try
            {
                var room = _dbContext.Rooms.FirstOrDefault(x => x.Id == id);
                _dbContext.Rooms.Remove(room);
                _dbContext.SaveChanges();
                return room;

            }
            catch (Exception ex) {
                return null;
            }
        }

        public Room Update( Room _room)
        {
            try
            {
                var room = _dbContext.Rooms.FirstOrDefault(x => x.Id == _room.Id);
                room.Id = _room.Id;
                room.NumberRoom = _room.NumberRoom;
                room.Status = _room.Status;
                room.TypeRoomId = _room.TypeRoomId;
                _dbContext.Rooms.Update(room);
                _dbContext.SaveChanges();
                return room;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
