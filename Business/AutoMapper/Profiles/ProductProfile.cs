using AutoMapper;
using Entities.DTOs.ProductDto;
using Entities.Concrete;

namespace Business.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductDeleteDto, Product>().ReverseMap();
        }
    }
}