using AutoMapper;
using ShopWebAPI.DTOs;
using ShopWebAPI.Models;

public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<Products, ShopWebDTO>()
                   .ForMember(dest => dest.IdProduct, opt => opt.MapFrom(src => src.IdProduct));
                   //.ForMember(dest => dest.IdProduct, opt => opt.MapFrom(src => src.StateProductId));
        CreateMap<ShopWebInsertDTO, ShopWebDTO>();
        CreateMap<ShopWebInsertDTO, Products>();
        CreateMap<ShopWebUpdateDTO, Products>();


    }
}
