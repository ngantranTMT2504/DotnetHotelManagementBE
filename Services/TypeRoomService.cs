using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Services
{
    public class TypeRoomService : ITypeRoomService
    {
        private readonly HotelManagementDbContext _dbContext;

        public TypeRoomService(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TypeRoom GetById(int id)
        {
            try
            {
                var typeRoom = _dbContext.TypeRooms
                    .FirstOrDefault(x => x.Id == id);
                return typeRoom;

            }
            catch {
                return null;
            }
        }

        public List<TypeRoom> GetAll()
        {
            try
            {
                var allTypeRoom = _dbContext.TypeRooms
                .ToList();
                return allTypeRoom;

            } catch
            {
                return null;
            }
        }

        public TypeRoom Add(TypeRoom typeRoom)
        {
            try
            {
            _dbContext.TypeRooms.Add(typeRoom);
            _dbContext.SaveChanges();
            return typeRoom;

            } catch
            {
                return null;
            }
        }

        public TypeRoom Delete(int id)
        {
            try
            {
                var typeRoom = _dbContext.TypeRooms.FirstOrDefault(r => r.Id == id);
                _dbContext.TypeRooms.Remove(typeRoom);
                _dbContext.SaveChanges();
                return typeRoom;

            } catch
            {
                return null;
            }
        }

        public TypeRoom Update(TypeRoom _typeRoom)
        {
            try
            {
                var typeRoomFromDb = _dbContext.TypeRooms.FirstOrDefault(r => r.Id == _typeRoom.Id);
                typeRoomFromDb.Name = _typeRoom.Name;
                typeRoomFromDb.Price = _typeRoom.Price;
                typeRoomFromDb.Capacity= _typeRoom.Capacity;
                typeRoomFromDb.Description = _typeRoom.Description;
                typeRoomFromDb.ImageRoom = _typeRoom.ImageRoom;
                _dbContext.TypeRooms.Update(typeRoomFromDb);
                _dbContext.SaveChanges();
                return typeRoomFromDb;
            } catch
            {
                return null;
            }
        }

    }
}
