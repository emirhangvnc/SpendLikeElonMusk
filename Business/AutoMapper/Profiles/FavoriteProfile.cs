using AutoMapper;
using Entities.DTOs.FavoriteDto;
using Entities.Concrete;

namespace Business.AutoMapper.Profiles
{
    public class FavoriteProfile : Profile
    {
        public FavoriteProfile()
        {
            CreateMap<FavoriteAddDto, Favorite>().ReverseMap();
            CreateMap<FavoriteDeleteDto, Favorite>().ReverseMap();
            CreateMap<FavoriteUpdateDto, Favorite>().ReverseMap();
        }
    }
}