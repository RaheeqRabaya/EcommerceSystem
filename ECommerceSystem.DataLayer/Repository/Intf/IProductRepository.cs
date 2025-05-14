using System.Collections.Generic;
using ECommerceSystem.DataLayer.Entities;

namespace ECommerceSystem.DataLayer.Repository.Intf
{
    public interface IProductRepository
    {
        void SaveProducts(List<Product> products);
        List<Product> LoadProducts();
    }
}
