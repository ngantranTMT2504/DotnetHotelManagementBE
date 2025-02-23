using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ServiceController : Controller
    {
        private readonly IServicesManagementService _serviceManagementService;

        public ServiceController(IServicesManagementService serviceManagementService)
        {
            _serviceManagementService = serviceManagementService;
        }

        [Route("GetServices")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _serviceManagementService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddService")]
        [HttpPost]
        public IActionResult Add(Service service)
        {
            try
            {
                var _service = _serviceManagementService.Add(service);
                if (_service == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(service);
        }

        [Route("GetService/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var service = _serviceManagementService.GetById(id);
            if (service == null)
                return NotFound();
            return Ok(service);
        }

        [Route("DeleteService/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var service = _serviceManagementService.Delete(id);

            if (service == null)
                return BadRequest();
            return Ok(service);
        }

        [Route("UpdateService")]
        [HttpPut]
        public IActionResult Update(Service _service)
        {
            var service = _serviceManagementService.Update(_service);

            if (service == null)
                return BadRequest();
            return Ok(service);
        }
    }
}
