namespace ECommerceSystem.BusinessLayer.Managers.Intf
{
    public interface IPayment
    {
        bool ProcessPayment(double amount);
    }
}
