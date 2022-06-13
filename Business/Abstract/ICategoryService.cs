using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CategoryDto;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetALl();
        IDataResult<Category> GetByCategoryId(int categoryId);

        IResult Add(CategoryAddDto categoryAddDto);
        IResult Delete(CategoryDeleteDto categoryDeleteDto);
        IResult Update(CategoryUpdateDto categoryUpdateDto);
    }
}