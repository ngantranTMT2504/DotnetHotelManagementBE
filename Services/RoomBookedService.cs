using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;

namespace HotelManagement.Services
{
    public class RoomBookedService : IRoomBookedService
    {
        private readonly HotelManagementDbContext _dbContext;

        public RoomBookedService(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public RoomBooked Add(RoomBooked roomBooked)
        {
            try
            {
                _dbContext.RoomsBookeds.Add(roomBooked);
                _dbContext.SaveChanges();
                return roomBooked;
            }
            catch
            {
                return null;
            }
        }

        public RoomBooked Delete(int id)
        {
            try
            {
                var roomBooked = _dbContext.RoomsBookeds.FirstOrDefault(r => r.Id == id);
                _dbContext.RoomsBookeds.Remove(roomBooked);
                _dbContext.SaveChanges();
                return roomBooked;
            }
            catch
            {
                return null;
            }
        }

        public List<RoomBooked> GetAll()
        {
            try
            {
                var roomBooked = _dbContext.RoomsBookeds.ToList();
                return roomBooked;
            }
            catch
            {
                return null;
            }
        }

        public RoomBooked GetById(int id)
        {
            try
            {
                var roomBooked = _dbContext.RoomsBookeds.FirstOrDefault(x => x.Id == id);
                return roomBooked;
            }
            catch
            {
                return null;
            }
        }

        public RoomBooked Update(RoomBooked _roomBooked)
        {
            try
            {
                var roomBooked = _dbContext.RoomsBookeds.FirstOrDefault(_x => _x.Id == _roomBooked.Id);
                roomBooked.RoomId = _roomBooked.Id;
                _dbContext.RoomsBookeds.Update(roomBooked);
                _dbContext.SaveChanges();
                return roomBooked;
            }
            catch
            {
                return null;
            }
        }
    }
}
