using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BookingServiceController : Controller
    {
        private readonly IBookingServicesService _bookingServicesService;

        public BookingServiceController(IBookingServicesService bookingServicesService)
        {
            _bookingServicesService = bookingServicesService;
        }

        [Route("GetBookingService")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _bookingServicesService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddBookingService")]
        [HttpPost]
        public IActionResult Add(BookingService bookingService)
        {
            try
            {
                var _bookingService = _bookingServicesService.Add(bookingService);
            if (_bookingService == null)
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(bookingService);
        }

        [Route("GetBookingService/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var bookingService = _bookingServicesService.GetById(id);
            if (bookingService == null)
                return NotFound();
            return Ok(bookingService);
        }

        [Route("DeleteBookingService/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var bookingService = _bookingServicesService.Delete(id);

            if (bookingService == null)
                return BadRequest();
            return Ok(bookingService);
        }

        [Route("UpdateBookingService")]
        [HttpPut]
        public IActionResult Update(int id, BookingService _bookingService)
        {
            var bookingService = _bookingServicesService.Update(_bookingService);

            if (bookingService == null)
                return BadRequest();
            return Ok(bookingService);
        }
    }
}
