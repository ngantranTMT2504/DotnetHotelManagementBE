using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IServicesManagementService
    {

        Service GetById(int id);
        List<Service> GetAll();
        Service Add(Service service);

        public Service Delete(int id);
        public Service Update( Service service);

    }
}
