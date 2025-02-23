using HotelManagement.Interfaces;
using HotelManagement.Models;
using HotelManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("GetUser")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _userService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddUser")]
        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                var _user = _userService.Add(user);
                if (user == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(user);
        }

        [Route("GetUser/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [Route("DeleteUser/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var user = _userService.Delete(id);

            if (user == null)
                return BadRequest();
            return Ok(user);
        }

        [Route("UpdateUser")]
        [HttpPut]
        public IActionResult Update(User _user)
        {
            var user = _userService.Update(_user);

            if (user == null)
                return BadRequest();
            return Ok(user);
        }
    }
}
