using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDto;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetALl();
        IDataResult<Product> GetByProductId();

        IResult Add(ProductAddDto productAddDto);
        IResult Delete(ProductDeleteDto productDeleteDto);
        IResult Update(ProductUpdateDto productUpdateDto);
    }
}