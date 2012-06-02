using System.ComponentModel.DataAnnotations;
namespace WebAppAsync.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}