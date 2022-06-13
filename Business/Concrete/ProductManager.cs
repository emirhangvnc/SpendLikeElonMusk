using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDto;
using DataAccess.Abstract;
using AutoMapper;
using Core.Aspects.Ninject.Caching;
using Core.Aspects.Ninject.Validation;
using Business.ValidationRules.FluentValidation.ProductValidator;
using Business.Constants;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IMapper _mapper;
        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(ProductAddDtoValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(ProductAddDto productAddDto)
        {
            var product = _mapper.Map<Product>(productAddDto);
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        [ValidationAspect(typeof(ProductDeleteDtoValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Delete(ProductDeleteDto productDeleteDto)
        {
            var result = _productDal.GetAll().SingleOrDefault(c => c.ProductId == productDeleteDto.ProductId);
            if (result == null)
                return new ErrorResult(Messages.ProductNotFound);
            _productDal.Delete(result);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [ValidationAspect(typeof(ProductUpdateDtoValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(ProductUpdateDto productUpdateDto)
        {
            var result = _productDal.GetAll().SingleOrDefault(c => c.ProductId == productUpdateDto.ProductId);
            if (result == null)
                return new ErrorResult(Messages.ProductNotFound);

            var product = _mapper.Map(productUpdateDto, result);
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Product>> GetALl()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);
        }

        [CacheAspect]
        public IDataResult<Product> GetByProductId(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }
    }
}