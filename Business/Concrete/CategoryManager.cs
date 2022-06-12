using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using AutoMapper;

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
        public IResult Add(CategoryAddDto categoryAddDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CategoryDeleteDto categoryDeleteDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetALl()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> GetByCategoryId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(CategoryUpdateDto categoryUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
