using BL.Managers.PaymentManagers;
using DAL.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoBusAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentsController : ControllerBase
{
    private readonly IPaymentManager _paymentManager;

    public PaymentsController(IPaymentManager paymentManager)
    {
        _paymentManager = paymentManager;
    }

    [HttpGet("{reservationId:int}")]
    public async Task<ActionResult<Reservation>> CreateOrUpdatePaymentIntent(int reservationId)
    {
        Response response = await _paymentManager.CreateOrUpdatePaymentIntent(reservationId);

        if (response.Success)
        {
            return Ok(response);
        }

        return NotFound(response);
    }

}
