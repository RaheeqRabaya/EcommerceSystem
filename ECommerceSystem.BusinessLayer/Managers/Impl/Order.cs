using System;
using System.Collections.Generic;
using ECommerceSystem.BusinessLayer.Managers.Intf;
using ECommerceSystem.DataLayer.Entities;
using ECommerceSystem.DataLayer.Enums;

namespace ECommerceSystem.BusinessLayer.Managers.Impl
{
    public class Order : IDiscountable
    {
        public List<Product> Products { get; }
        public DateTime OrderDate { get; }
        public OrderStatus Status { get; set; }

        public Order(List<Product> products, OrderStatus status)
        {
            Products = products ?? throw new ArgumentNullException(nameof(products));
            OrderDate = DateTime.Now;
            Status = status;
        }

        public double ApplyDiscount(double percent)
        {
            if (percent < 0 || percent > 100)
                throw new ArgumentOutOfRangeException(nameof(percent), "Discount percent must be between 0 and 100.");

            double total = 0;
            foreach (var p in Products)
                total += p.Price;

            return total - (total * percent / 100);
        }
    }
}
