using HotelManagement.Interfaces;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {

        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [Route("GetPayments")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var all = _paymentService.GetAll();
            if (all == null)
                return NotFound();

            return Ok(all);
        }

        [Route("AddPayment")]
        [HttpPost]
        public IActionResult Add(Payment payment)
        {
            try
            {
                var _payment = _paymentService.Add(payment);
                if (_payment == null)
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(payment);
        }

        [Route("GetPayment/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var payment = _paymentService.GetById(id);
            if (payment == null)
                return NotFound();
            return Ok(payment);
        }

        [Route("DeletePayment/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var payment = _paymentService.Delete(id);

            if (payment == null)
                return BadRequest();
            return Ok(payment);
        }

        [Route("UpdatePayment")]
        [HttpPut]
        public IActionResult Update(Payment _payment)
        {
            var payment = _paymentService.Update(_payment);

            if (payment == null)
                return BadRequest();
            return Ok(payment);
        }
    }
}
