using AutoMapper;
using Entities.DTOs.FortuneDto;
using Entities.Concrete;

namespace Business.AutoMapper.Profiles
{
    public class FortuneProfile : Profile
    {
        public FortuneProfile()
        {
            CreateMap<FortuneAddDto, Fortune>().ReverseMap();
            CreateMap<FortuneUpdateDto, Fortune>().ReverseMap();
        }
    }
}