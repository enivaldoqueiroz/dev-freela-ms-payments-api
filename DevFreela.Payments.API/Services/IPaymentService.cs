using DevFreela.Payments.API.Model;

namespace DevFreela.Payments.API.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessPayment(PaymentInfoInputModel paymentInfoInputModel);
    }
}
