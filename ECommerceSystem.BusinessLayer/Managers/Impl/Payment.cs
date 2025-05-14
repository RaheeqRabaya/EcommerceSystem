using System;
using ECommerceSystem.BusinessLayer.Managers.Intf;

namespace ECommerceSystem.BusinessLayer.Managers.Impl
{
    public class Payment : IPayment
    {
        public bool ProcessPayment(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid payment amount.");
                return false;
            }

            Console.WriteLine($"Processing payment: {amount:C}");
            Console.WriteLine("Payment Successful.");
            return true;
        }
    }
}
