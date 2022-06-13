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
using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.FileHelper;

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
        public IResult Add(IFormFile file, ProductAddDto productAddDto)
        {
            var product = _mapper.Map<Product>(productAddDto);
            product.ImagePath = FileHelper.Add(file);
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
            string path = GetByProductId(result.ProductId).Data.ImagePath;
            FileHelper.Delete(path);
            _productDal.Delete(result);
            return new SuccessResult(Messages.ProductDeleted);
        }

        [ValidationAspect(typeof(ProductUpdateDtoValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(IFormFile file, ProductUpdateDto productUpdateDto)
        {
            var result = _productDal.GetAll().SingleOrDefault(c => c.ProductId == productUpdateDto.ProductId);
            if (result == null)
                return new ErrorResult(Messages.ProductNotFound);

            var product = _mapper.Map(productUpdateDto, result);
            var oldImage = GetByProductId(product.ProductId).Data;
            product.ImagePath = FileHelper.Update(file, oldImage.ImagePath);

            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Product>> GetAll()
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