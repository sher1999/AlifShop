using AutoMapper;
using Domain.Dtos;
using Domain.Entities;


namespace Infrastructure.MapperProfiles;

public class InfrastructureProfile : Profile
{
    public InfrastructureProfile()
    {
        CreateMap<Category,GetCategoryDto>().ReverseMap();
        CreateMap<Category,AddCategoryDto>().ReverseMap();
        CreateMap<Customer,GetCostomerDto>().ReverseMap();
        CreateMap<Customer,AddCostomerDto>().ReverseMap();
        CreateMap<Order,GetOrderDto>().ReverseMap();
        CreateMap<Order,AddOrderDto>().ReverseMap();
        CreateMap<OrderProduct,GetOrderProductDto>().ReverseMap();
        CreateMap<OrderProduct,AddOrderProductDto>().ReverseMap();
        CreateMap<Product,GetProductDto>().ReverseMap();
        CreateMap<Product,AddProductDto>().ReverseMap();
    }
}