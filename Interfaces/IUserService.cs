using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        User Add(User user);

        public User Delete(int id);
        public User Update(User user);
    }
}
