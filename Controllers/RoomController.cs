using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [Route("GetRooms")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _roomService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddRoom")]
        [HttpPost]
        public IActionResult Add(Room room)
        {
            try
            {
                var _room = _roomService.Add(room);
                if (_room == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(room);
        }

        [Route("GetRoom/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var room = _roomService.GetById(id);
            if (room == null)
                return NotFound();
            return Ok(room);
        }

        [Route("DeleteRoom/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var room = _roomService.Delete(id);

            if (room == null)
                return BadRequest();
            return Ok(room);
        }

        [Route("UpdateRoom/{id}")]
        [HttpPut]
        public IActionResult Update(Room _room)
        {
            var room = _roomService.Update(_room);

            if (room == null)
                return BadRequest();
            return Ok(room);
        }
    }
}
