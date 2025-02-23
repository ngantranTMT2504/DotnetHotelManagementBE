using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;

namespace HotelManagement.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HotelManagementDbContext _dbContext;

        public PaymentService(HotelManagementDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Payment Add(Payment payment)
        {
            try
            {
                _dbContext.Payment.Add(payment);
                _dbContext.SaveChanges();
                return payment;
            } catch (Exception ex)
            {
                throw;
            }
        }

        public Payment Delete(int id)
        {
            try
            {
                var payment = _dbContext.Payment.FirstOrDefault(x => x.Id == id);
                _dbContext.Payment.Remove(payment);
                _dbContext.SaveChanges();
                return payment;
            } catch
            {
                return null;
            }
        }

        public List<Payment> GetAll()
        {
            try
            {
                var payments = _dbContext.Payment.ToList();
                return payments;
            } catch
            {
                return null;
            }
        }

        public Payment GetById(int id)
        {
            try
            {
                var payment = _dbContext.Payment.FirstOrDefault(x =>x.Id == id);
                return payment;
            } catch
            {
                return null;
            }
        }

        public Payment Update(Payment _payment)
        {
            try
            {
                var payment = _dbContext.Payment.FirstOrDefault(x => x.Id==_payment.Id);
                payment.Id = _payment.Id;
                payment.Amount = _payment.Amount;
                payment.UpFrontPayment = _payment.UpFrontPayment;
                payment.Method = _payment.Method;
                payment.BookingId = _payment.BookingId;
                _dbContext.Payment.Update(payment);
                _dbContext.SaveChanges();
                return payment;
            } catch
            {
                return null;
            }
        }
    }
}
