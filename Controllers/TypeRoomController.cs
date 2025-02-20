using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TypeRoomController : Controller
    {
        [Route("GetTypeRooms")]
        [HttpGet]
        public IActionResult GetTypeRoom() {
        
                return Ok("TestTypeRoom");
        }

        [Route("AddTypeRoom")]
        [HttpPost]
        public IActionResult AddTypeRooms(TypeRoom typeRoom)
        {
            return Ok(typeRoom);
        }

        [Route("GetTypeRoom/{id}")]
        [HttpGet]
        public IActionResult GetTypeRoom(string id, string test)
        {
            return Ok(id);
        }
    }
}
