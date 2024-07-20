using DevFreela.Payments.API.Model;
using DevFreela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.Controllers
{
    [Route("api/payments")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentsService;

        public PaymentsController(IPaymentService paymentsService)
        {
            _paymentsService = paymentsService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
            var result = await _paymentsService.ProcessPayment(paymentInfoInputModel);

            if (!result)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
