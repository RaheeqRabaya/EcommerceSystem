using System.Collections.Generic;

namespace ECommerceSystem.DataLayer.Entities
{
    public class ShoppingCart
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product != null)
                Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var p in Products)
                total += p.Price;
            return total;
        }
    }
}
