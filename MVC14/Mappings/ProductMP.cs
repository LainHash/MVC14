using AutoMapper;
using MVC14.Models;
using MVC14.DTOs.Products.Create;
using MVC14.DTOs.Products.Update;
using MVC14.ViewModels;

namespace MVC14.Mappings
{
    public class ProductMP : Profile
    {
        public ProductMP() {
            CreateMap<VwProduct, ProductVM>().ReverseMap();

            CreateMap<CreateProductDTO, Product>();
            CreateMap<CreateLaptopDTO, Laptop>();
            CreateMap<CreateCpuDTO, Cpu>();
            CreateMap<CreateGpuDTO, Gpu>();
            CreateMap<CreateRamDTO, Ram>();
            CreateMap<CreateStorageDTO, Storage>();

            CreateMap<UpdateProductDTO, Product>().ReverseMap();
            CreateMap<UpdateLaptopDTO, Laptop>()
                .ForMember(dest => dest.ProductSku, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UpdateCpuDTO, Cpu>()
                .ForMember(dest => dest.ProductSku, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UpdateGpuDTO, Gpu>()
                .ForMember(dest => dest.ProductSku, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UpdateRamDTO, Ram>()
                .ForMember(dest => dest.ProductSku, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<UpdateStorageDTO, Storage>()
                .ForMember(dest => dest.ProductSku, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
