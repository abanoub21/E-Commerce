using AutoMapper;
using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Entites.Categories;
namespace E.Commerce.Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Product, ProductRequestDto>().ReverseMap();
            CreateMap<Product, ProductResponseDto>().ReverseMap();
            CreateMap<Cart, CartResponseDto>().ReverseMap();
            CreateMap<Cart, CartRequestDto>().ReverseMap();
            CreateMap<Cart, OrderProduct>().ReverseMap();
            CreateMap<OrderProductDto, OrderProduct>().ReverseMap();
            CreateMap<Ordered,OrderedDto>().ReverseMap();
            CreateMap<Category, CategoryResponseDto>().ReverseMap();
            CreateMap<Category, CategoryRequestDto>().ReverseMap();
            
        }
    }
}
