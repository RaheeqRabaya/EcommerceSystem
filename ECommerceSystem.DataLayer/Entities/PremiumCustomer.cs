namespace ECommerceSystem.DataLayer.Entities
{
    public sealed class PremiumCustomer : Person
    {
        public PremiumCustomer(int id, string name)
            : base(id, name)
        {
        }

        public double GetPremiumDiscount() => 20;
    }
}
