using HotelManagement.Models;

namespace HotelManagement.Interfaces
{
    public interface IPaymentService
    {
        Payment GetById(int id);
        List<Payment> GetAll();
        Payment Add(Payment payment);

        public Payment Delete(int id);
        public Payment Update(Payment payment);
    }
}
