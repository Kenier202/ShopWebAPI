using AutoMapper;
using ShopWebAPI.DTOs;
using ShopWebAPI.Models;

public class MappingProfile : Profile
{
    public MappingProfile() 
    {
        CreateMap<Products, ShopWebDTO>();
        CreateMap<ShopWebInsertDTO, ShopWebDTO>();
        CreateMap<ShopWebInsertDTO, Products>();
        CreateMap<ShopWebUpdateDTO, Products>();


    }
}
