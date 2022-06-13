using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.PersonalWealthDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;
using Core.Aspects.Ninject.Validation;
using Business.ValidationRules.FluentValidation.PersonalWealthValidator;
using Core.Aspects.Ninject.Caching;
using Business.Constants;

namespace Business.Concrete
{
    public class PersonalWealthManager : IPersonalWealthService
    {
        IPersonalWealthDal _personalWealthDal;
        IMapper _mapper;
        public PersonalWealthManager(IPersonalWealthDal personalWealthDal,IMapper mapper)
        {
            _personalWealthDal = personalWealthDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(PersonalWealthAddDtoValidator))]
        [CacheRemoveAspect("IPersonalWealthService.Get")]
        public IResult Add(PersonalWealthAddDto personalWealthAddDto)
        {
            var personal = _mapper.Map<PersonalWealth>(personalWealthAddDto);
            _personalWealthDal.Add(personal);
            return new SuccessResult(Messages.PersonalWealthAdded);
        }

        [ValidationAspect(typeof(PersonalWealthDeleteDtoValidator))]
        [CacheRemoveAspect("IPersonalWealthService.Get")]
        public IResult Delete(PersonalWealthDeleteDto personalWeathDeleteDto)
        {
            var result = _personalWealthDal.GetAll().SingleOrDefault(f => f.Id == personalWeathDeleteDto.Id);
            if (result == null)
                return new ErrorResult(Messages.PersonalWealthNotFound);
            _personalWealthDal.Delete(result);
            return new SuccessResult(Messages.PersonalWealthDeleted);
        }

        [ValidationAspect(typeof(PersonalWealthUpdateDtoValidator))]
        [CacheRemoveAspect("IPersonalWealthService.Get")]
        public IResult Update(PersonalWealthUpdateDto personalWeathUpdateDto)
        {
            var result = _personalWealthDal.GetAll().SingleOrDefault(p => p.Id == personalWeathUpdateDto.Id);
            if (result == null)
                return new ErrorResult(Messages.PersonalWealthUpdated);

            var personal = _mapper.Map(personalWeathUpdateDto, result);
            _personalWealthDal.Update(personal);
            return new SuccessResult(Messages.PersonalWealthUpdated);
        }

        [CacheAspect]
        public IDataResult<List<PersonalWealth>> GetAll()
        {
            return new SuccessDataResult<List<PersonalWealth>>(_personalWealthDal.GetAll(),Messages.PersonalWealthListed);
        }

        [CacheAspect]
        public IDataResult<PersonalWealth> GetByPersonalWealthId(int personalWealth)
        {
            return new SuccessDataResult<PersonalWealth>(_personalWealthDal.Get(p => p.Id == personalWealth));
        }
    }
}