using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDto;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetByProductId(int productId);

        IResult Add(IFormFile file, ProductAddDto productAddDto);
        IResult Delete(ProductDeleteDto productDeleteDto);
        IResult Update(IFormFile file, ProductUpdateDto productUpdateDto);
    }
}