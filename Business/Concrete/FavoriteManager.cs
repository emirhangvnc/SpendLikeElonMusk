using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs.FavoriteDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;

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
        public IResult Add(FavoriteAddDto favoriteAddDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(FavoriteDeleteDto favoriteDeleteDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Favorite>> GetALl()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Favorite> GetByFavoriteId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(FavoriteUpdateDto favoriteUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}