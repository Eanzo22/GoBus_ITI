using DAL.Data.Models;

namespace BL.Managers.PaymentManagers;

public interface IPaymentManager
{
    Task<Response> CreateOrUpdatePaymentIntent(int reservationId);
}
