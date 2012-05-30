using System.Collections.Generic;

namespace WebAPIpgw.Models
{    
    public class Product
    {
        public Product() { }   // empty ctor required
        public Product(int cnt)
        {
            Id = cnt;
            Name = "Product " + cnt.ToString();
            Price = .99M + cnt;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Simulate a call to a back end store such as SQL Server
        public static IEnumerable<Product> GetProducts()
        {
            for (int i = 1; i < 3; i++)
            {
                yield return new Product(i);
            }
        }
    }
}