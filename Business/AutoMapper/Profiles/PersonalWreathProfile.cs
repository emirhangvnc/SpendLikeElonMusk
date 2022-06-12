using AutoMapper;
using Entities.DTOs.PersonalWeathDto;
using Entities.Concrete;

namespace Business.AutoMapper.Profiles
{
    public class PersonalWreathProfile : Profile
    {
        public PersonalWreathProfile()
        {
            CreateMap<PersonalWeathAddDto, Fortune>().ReverseMap();
            CreateMap<PersonalWeathDeleteDto, Fortune>().ReverseMap();
            CreateMap<PersonalWeathUpdateDto, Fortune>().ReverseMap();
        }
    }
}