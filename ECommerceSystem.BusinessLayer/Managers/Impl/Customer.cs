using ECommerceSystem.DataLayer.Entities;
using ECommerceSystem.DataLayer.Enums;

namespace ECommerceSystem.BusinessLayer.Managers.Impl
{
    public class Customer : Person
    {
        public ShoppingCart Cart { get; private set; }

        public Customer(int id, string name) : base(id, name)
        {
            Cart = new ShoppingCart();
        }

        public Order PlaceOrder()
        {
            return new Order(Cart.Products, OrderStatus.Pending);
        }
    }
}
