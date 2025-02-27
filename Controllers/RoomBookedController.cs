using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    
    public class RoomBookedController : Controller
    {
        private readonly IRoomBookedService _roomBookedService;

        public RoomBookedController(IRoomBookedService roomBookedService)
        {
            _roomBookedService = roomBookedService;
        }

        [Route("GetRoomBookeds")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _roomBookedService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddRoomBooked")]
        [HttpPost]
        public IActionResult Add(RoomBooked roomBooked)
        {
            try
            {
                var _roomBooked = _roomBookedService.Add(roomBooked);
                if (_roomBooked == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(roomBooked);
        }

        [Route("GetRoomBooked/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var roomBooked = _roomBookedService.GetById(id);
            if (roomBooked == null)
                return NotFound();
            return Ok(roomBooked);
        }

        [Route("DeleteRoomBooked/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var roomBooked = _roomBookedService.Delete(id);

            if (roomBooked == null)
                return BadRequest();
            return Ok(roomBooked);
        }

        [Route("UpdateRoomBooked")]
        [HttpPut]
        public IActionResult Update(RoomBooked _roomBooked)
        {
            var roomBooked = _roomBookedService.Update(_roomBooked);

            if (roomBooked == null)
                return BadRequest();
            return Ok(roomBooked);
        }
    }
}
