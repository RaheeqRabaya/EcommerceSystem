using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ECommerceSystem.DataLayer.Data;
using ECommerceSystem.DataLayer.Entities;
using ECommerceSystem.DataLayer.Repository.Intf;

namespace ECommerceSystem.DataLayer.Repository.Impl
{
    public class ProductRepository : IProductRepository
    {
        private const string FilePath = "products.json";

        public void SaveProducts(List<Product> products)
        {
            var sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < products.Count; i++)
            {
                var p = products[i];
                sb.Append($"{{\"ID\":{p.ID},\"Name\":\"{Escape(p.Name)}\",\"Price\":{p.Price.ToString(CultureInfo.InvariantCulture)}}}");
                if (i < products.Count - 1) sb.Append(",");
            }
            sb.Append("]");
            JsonDataProvider.WriteToFile(FilePath, sb.ToString());
        }

        public List<Product> LoadProducts()
        {
            var products = new List<Product>();
            string json = JsonDataProvider.ReadFromFile(FilePath);
            if (string.IsNullOrWhiteSpace(json)) return products;

            string[] entries = json.Trim('[', ']').Split("},");
            foreach (var entry in entries)
            {
                var clean = entry.Trim().Trim('{', '}', ',').Replace("\"", "");
                var parts = clean.Split(',');

                int id = 0;
                string name = string.Empty;
                double price = 0;

                foreach (var part in parts)
                {
                    var kv = part.Split(':');
                    if (kv.Length != 2) continue;

                    if (kv[0] == "ID") id = int.Parse(kv[1]);
                    else if (kv[0] == "Name") name = kv[1];
                    else if (kv[0] == "Price") price = double.Parse(kv[1], CultureInfo.InvariantCulture);
                }

                products.Add(new Product { ID = id, Name = name, Price = price });
            }

            return products;
        }

        private string Escape(string input) =>
            input.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }
}
