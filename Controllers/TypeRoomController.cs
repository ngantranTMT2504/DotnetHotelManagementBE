using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TypeRoomController : Controller
    {
        private readonly ITypeRoomService _typeRoomService;

        public TypeRoomController(ITypeRoomService typeRoomService)
        {
            _typeRoomService = typeRoomService;
        }

        [Route("GetTypeRooms")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var allTypeRoom = _typeRoomService.GetAll();
            if (allTypeRoom == null)
                return NotFound();

            return Ok(allTypeRoom);
        }

        [Route("AddTypeRoom")]
        [HttpPost]
        public IActionResult Add(TypeRoom typeRoom)
        {

            try
            {
                var type = _typeRoomService.Add(typeRoom);
                if (type == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(typeRoom);
        }

        [Route("GetTypeRoom/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var typeRoom = _typeRoomService.GetById(id);
            if (typeRoom == null)
                return NotFound();
            return Ok(typeRoom);
        }

        [Route("DeleteTypeRoom/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var typeRoom = _typeRoomService.Delete(id);

            if (typeRoom == null)
                return BadRequest();
            return Ok(typeRoom);
        }

        [Route("UpdateTypeRoom")]
        [HttpPut]
        public IActionResult Update(TypeRoom type)
        {
            var typeRoom = _typeRoomService.Update(type);

            if (typeRoom == null)
                return BadRequest();
            return Ok(typeRoom);
        }
    }
}
