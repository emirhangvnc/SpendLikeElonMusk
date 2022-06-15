using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CategoryDto;
using DataAccess.Abstract;
using AutoMapper;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation.CategoryValidator;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CategoryAddDtoValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(CategoryAddDto categoryAddDto)
        {
            var result = _categoryDal.GetAll().SingleOrDefault(c => c.CategoryName == categoryAddDto.CategoryName);
            if (result != null)
                return new ErrorResult("Bu İsimde Kategori Zaten Mevcut");
            var category = _mapper.Map<Category>(categoryAddDto);
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        [ValidationAspect(typeof(CategoryDeleteDtoValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Delete(CategoryDeleteDto categoryDeleteDto)
        {
            var result = _categoryDal.GetAll().SingleOrDefault(c => c.CategoryId == categoryDeleteDto.Id);
            if (result == null)
                return new ErrorResult(Messages.CategoryNotFound);
            _categoryDal.Delete(result);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        [ValidationAspect(typeof(CategoryUpdateDtoValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            var result = _categoryDal.GetAll().SingleOrDefault(c => c.CategoryId == categoryUpdateDto.Id);
            if (result == null)
                return new ErrorResult(Messages.CategoryNotFound);
            var category = _mapper.Map(categoryUpdateDto, result);
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
        }

        [CacheAspect]
        public IDataResult<Category> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(b => b.CategoryId == categoryId));
        }
    }
}