using Core.Entities;

namespace Entities.DTOs.ProductDto
{
    public class ProductUpdateDto : IDto
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}