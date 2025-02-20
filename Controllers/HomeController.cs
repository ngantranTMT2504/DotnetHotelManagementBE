using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [Route("GetProducts")]
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok("Test");
        }

        [Route("AddProduct")]
        [HttpPost]
        public IActionResult AddProduct(User product)
        {
            return Ok(product);
        }

        [Route("GetProduct/{id}")]
        [HttpGet]
        public IActionResult GetProduct(string id, string test)
        {
            return Ok(id);
        }
    }
}
