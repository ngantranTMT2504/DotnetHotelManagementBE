using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;

namespace HotelManagement.Services
{
    public class ServiceManagementService : IServicesManagementService
    {
        private readonly HotelManagementDbContext _dbContext;

        public ServiceManagementService(HotelManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Service Add(Service service)
        {
            try
            {
                _dbContext.Services.Add(service);
                _dbContext.SaveChanges();
                return service;
            } catch (Exception ex)
            {
                return null;
            }
        }

        public Service Delete(int id)
        {
            var service = _dbContext.Services.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(service);
            _dbContext.SaveChanges();
            return service;
        }

        public List<Service> GetAll()
        {
            try
            {
                var services = _dbContext.Services.ToList();
                return services;
            } catch
            {
                return null;
            }

        }

        public Service GetById(int id)
        {
            try
            {
                var service = _dbContext.Services.FirstOrDefault(x => x.Id==id);
                return service;
            } catch
            {
                return null;
            }

        }

        public Service Update( Service _service)
        {
            try
            {
                var service = _dbContext.Services.FirstOrDefault(x => x.Id == _service.Id);
                service.Id = _service.Id;
                service.Name = _service.Name;
                service.Description = _service.Description;
                service.Price = _service.Price;
                service.ImageService = _service.ImageService;
                _dbContext.Services.Update(service);
                _dbContext.SaveChanges();

                return service;
            } catch
            {
                return null;
            }
        }
    }
}
