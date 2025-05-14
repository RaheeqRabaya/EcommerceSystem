using System.Globalization;

namespace ECommerceSystem.DataLayer.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }

        public string GetProductInfo()
        {
            return $"{Name} (ID: {ID}) - Price: {Price.ToString("C", CultureInfo.CurrentCulture)}";
        }

        public void UpdatePrice(double newPrice)
        {
            if (newPrice >= 0)
                Price = newPrice;
        }
    }
}
