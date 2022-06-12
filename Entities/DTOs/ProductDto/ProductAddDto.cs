using Core.Entities;

namespace Entities.DTOs.ProductDto
{
    public class ProductAddDto:IDto
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
