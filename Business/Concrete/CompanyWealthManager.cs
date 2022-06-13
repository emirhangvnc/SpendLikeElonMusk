using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.CompanyWealthDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;
using Core.Aspects.Ninject.Caching;
using Core.Aspects.Ninject.Validation;
using Business.ValidationRules.FluentValidation.CompanyWealthValidator;
using Business.Constants;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Helpers.FileHelper;

namespace Business.Concrete
{
    public class CompanyWealthManager : ICompanyWealthService
    {
        ICompanyWealthDal _companyWealthDal;
        IMapper _mapper;
        public CompanyWealthManager(ICompanyWealthDal companyWealthDal, IMapper mapper)
        {
            _companyWealthDal = companyWealthDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(CompanyWealthAddDtoValidator))]
        [CacheRemoveAspect("ICompanyWealthService.Get")]
        public IResult Add(IFormFile file, CompanyWealthAddDto companyWealthAddDto)
        {
            var companyWealth = _mapper.Map<CompanyWealth>(companyWealthAddDto);
            companyWealth.CompanyImage = FileHelper.Add(file);
            _companyWealthDal.Add(companyWealth);
            return new SuccessResult(Messages.CompanyWealthAdded);
        }

        [ValidationAspect(typeof(CompanyWealthDeleteDtoValidator))]
        [CacheRemoveAspect("ICompanyWealthService.Get")]
        public IResult Delete(CompanyWealthDeleteDto companyWealthDeleteDto)
        {
            var result = _companyWealthDal.Get(c => c.Id == companyWealthDeleteDto.Id);
            if (result == null)
                return new ErrorResult(Messages.CompanyWealthNotFound);
            string path = GetByCompanyWealthId(result.Id).Data.CompanyImage;
            FileHelper.Delete(path);
            _companyWealthDal.Delete(result);
            return new SuccessResult(Messages.CompanyWealthDeleted);
        }

        [ValidationAspect(typeof(CompanyWealthUpdateDtoValidator))]
        [CacheRemoveAspect("ICompanyWealthService.Get")]
        public IResult Update(IFormFile file, CompanyWealthUpdateDto companyWealthUpdateDto)
        {
            var result = _companyWealthDal.Get(c => c.Id == companyWealthUpdateDto.Id);
            if (result == null)
                return new ErrorResult(Messages.CompanyWealthNotFound);

            var companyWealth = _mapper.Map(companyWealthUpdateDto, result);
            var oldImage = GetByCompanyWealthId(companyWealth.Id).Data;
            companyWealth.CompanyImage = FileHelper.Update(file, oldImage.CompanyImage);

            _companyWealthDal.Update(companyWealth);
            return new SuccessResult(Messages.CompanyWealthUpdated);
        }

        [CacheAspect]
        public IDataResult<List<CompanyWealth>> GetAll()
        {
            return new SuccessDataResult<List<CompanyWealth>>(_companyWealthDal.GetAll(),Messages.CompanyWealthListed);
        }

        [CacheAspect]
        public IDataResult<CompanyWealth> GetByCompanyWealthId(int companyWealthId)
        {
            return new SuccessDataResult<CompanyWealth>(_companyWealthDal.Get(c=>c.Id==companyWealthId));
        }
    }
}