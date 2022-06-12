using AutoMapper;
using Entities.DTOs.CompanyWealthDto;
using Entities.Concrete;

namespace Business.AutoMapper.Profiles
{
    public class CompanyWealthProfile : Profile
    {
        public CompanyWealthProfile()
        {
            CreateMap<CompanyWealthAddDto, CompanyWealth>().ReverseMap();
            CreateMap<CompanyWealthDeleteDto, CompanyWealth>().ReverseMap();
            CreateMap<CompanyWealthUpdateDto, CompanyWealth>().ReverseMap();
        }
    }
}