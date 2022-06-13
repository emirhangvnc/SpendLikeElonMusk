using Business.Abstract;
using Core.Utilities.Results;
using Entities.DTOs.FavoriteDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;
using Core.Aspects.Ninject.Validation;
using Business.ValidationRules.FluentValidation.FavoriteValidator;
using Core.Aspects.Ninject.Caching;
using Business.Constants;

namespace Business.Concrete
{
    public class FavoriteManager : IFavoriteService
    {
        IFavoriteDal _favoriteDal;
        IMapper _mapper;
        public FavoriteManager(IFavoriteDal favoriteDal, IMapper mapper)
        {
            _favoriteDal = favoriteDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(FavoriteAddDtoValidator))]
        [CacheRemoveAspect("IFavoriteService.Get")]
        public IResult Add(FavoriteAddDto favoriteAddDto)
        {
            var favorite = _mapper.Map<Favorite>(favoriteAddDto);
            _favoriteDal.Add(favorite);
            return new SuccessResult(Messages.FavoriteAdded);
        }

        [ValidationAspect(typeof(FavoriteDeleteDtoValidator))]
        [CacheRemoveAspect("IFavoriteService.Get")]
        public IResult Delete(FavoriteDeleteDto favoriteDeleteDto)
        {
            var result = _favoriteDal.Get(f => f.FavoriteId == favoriteDeleteDto.Id);
            if (result == null)
                return new ErrorResult(Messages.FavoriteNotFound);
            _favoriteDal.Delete(result);
            return new SuccessResult(Messages.FavoriteDeleted);
        }

        [ValidationAspect(typeof(FavoriteUpdateDtoValidator))]
        [CacheRemoveAspect("IFavoriteService.Get")]
        public IResult Update(FavoriteUpdateDto favoriteUpdateDto)
        {
            var result = _favoriteDal.Get(f => f.FavoriteId == favoriteUpdateDto.Id);
            if (result == null)
                return new ErrorResult(Messages.FavoriteNotFound);
            var favorite = _mapper.Map(favoriteUpdateDto, result);
            _favoriteDal.Update(favorite);
            return new SuccessResult(Messages.FavoriteUpdated);
        }

        [CacheAspect]
        public IDataResult<List<Favorite>> GetAll()
        {
            return new SuccessDataResult<List<Favorite>>(_favoriteDal.GetAll(), Messages.FavoriteListed);
        }

        [CacheAspect]
        public IDataResult<Favorite> GetByFavoriteId(int favoriteId)
        {
            return new SuccessDataResult<Favorite>(_favoriteDal.Get(f => f.FavoriteId == favoriteId));
        }
    }
}