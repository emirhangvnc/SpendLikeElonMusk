using AutoMapper;
using Entities.DTOs.PersonalWealthDto;
using Entities.Concrete;

namespace Business.AutoMapper.Profiles
{
    public class PersonalWrealthProfile : Profile
    {
        public PersonalWrealthProfile()
        {
            CreateMap<PersonalWealthAddDto, Fortune>().ReverseMap();
            CreateMap<PersonalWealthUpdateDto, Fortune>().ReverseMap();
        }
    }
}