using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [Route("GetBooking")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _bookingService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddBooking")]
        [HttpPost]
        public IActionResult Add(Booking booking)
        {
            try
            {
                var _booking = _bookingService.Add(booking);
                if (_booking == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(booking);
        }

        [Route("GetBooking/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var booking = _bookingService.GetById(id);
            if (booking == null)
                return NotFound();
            return Ok(booking);
        }

        [Route("DeleteBooking/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var booking = _bookingService.Delete(id);

            if (booking == null)
                return BadRequest();
            return Ok(booking);
        }

        [Route("UpdateBooking")]
        [HttpPut]
        public IActionResult Update(Booking _booking)
        {
            var booking = _bookingService.Update(_booking);

            if (booking == null)
                return BadRequest();
            return Ok(booking);
        }
    }
}
