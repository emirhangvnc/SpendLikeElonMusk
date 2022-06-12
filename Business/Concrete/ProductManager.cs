using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using AutoMapper;

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
        public IResult Add(ProductAddDto productAddDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ProductDeleteDto productDeleteDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Product>> GetALl()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetByProductId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(ProductUpdateDto productUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
