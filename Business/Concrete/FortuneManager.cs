using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.FortuneDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation.FortuneValidator;
using Core.Aspects.Autofac.Caching;
using Business.Constants;

namespace Business.Concrete
{
    public class FortuneManager : IFortuneService
    {
        IFortuneDal _fortuneDal;
        IMapper _mapper;
        public FortuneManager(IFortuneDal fortuneDal, IMapper mapper)
        {
            _fortuneDal = fortuneDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(FortuneAddDtoValidator))]
        [CacheRemoveAspect("IFortuneService.Get")]
        public IResult Add(FortuneAddDto fortuneAddDto)
        {
            var fortune = _mapper.Map<Fortune>(fortuneAddDto);
            fortune.UpdateDate = DateTime.Now;
            _fortuneDal.Add(fortune);
            return new SuccessResult(Messages.FortuneAdded);
        }

        [ValidationAspect(typeof(FortuneDeleteDtoValidator))]
        [CacheRemoveAspect("IFortuneService.Get")]
        public IResult Delete(FortuneDeleteDto fortuneDeleteDto)
        {
            var result = _fortuneDal.Get(f => f.Id == fortuneDeleteDto.Id);
            if (result == null)
                return new ErrorResult(Messages.FortuneNotFound);
            _fortuneDal.Delete(result);
            return new SuccessResult(Messages.FortuneDeleted);
        }

        [ValidationAspect(typeof(FortuneUpdateDtoValidator))]
        [CacheRemoveAspect("IFortuneService.Get")]
        public IResult Update(FortuneUpdateDto fortuneUpdateDto)
        {
            var result = _fortuneDal.GetAll().SingleOrDefault(c => c.Id == fortuneUpdateDto.Id);
            if (result == null)
                return new ErrorResult(Messages.FortuneNotFound);
            var fortune = _mapper.Map(fortuneUpdateDto, result);
            _fortuneDal.Update(fortune);
            return new SuccessResult(Messages.FortuneUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Fortune>> GetAll()
        {
            return new SuccessDataResult<List<Fortune>>(_fortuneDal.GetAll(), Messages.FortuneListed);
        }

        [CacheAspect]
        public IDataResult<Fortune> GetByFortuneId(int fortuneId)
        {
            return new SuccessDataResult<Fortune>(_fortuneDal.Get(f => f.Id == fortuneId));
        }
    }
}