using Core.Entities;

namespace Entities.DTOs.ProductDto
{
    public class ProductDeleteDto : IDto
    {
        public int ProductId { get; set; }
    }
}