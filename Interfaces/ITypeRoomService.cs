using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface ITypeRoomService
    {
        TypeRoom GetById(int id);
        List<TypeRoom> GetAll();
        TypeRoom Add(TypeRoom typeRoom);

        public TypeRoom Delete(int id);
        public TypeRoom Update(TypeRoom typeRoom);

    }
}
