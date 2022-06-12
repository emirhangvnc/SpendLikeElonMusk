using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.FavoriteDto;

namespace Business.Abstract
{
    public interface IFavoriteService
    {
        IDataResult<List<Favorite>> GetALl();
        IDataResult<Favorite> GetByFavoriteId();

        IResult Add(FavoriteAddDto favoriteAddDto);
        IResult Delete(FavoriteDeleteDto favoriteDeleteDto);
        IResult Update(FavoriteUpdateDto favoriteUpdateDto);
    }
}