using AutoMapper;
using MVC14.DTOs.Products.Create;

namespace MVC14.Models
{
    public partial class ProductSku
    {
        public ProductSku() { }
        public ProductSku(CreateProductDTO dto, Cpu? cpu, Gpu? gpu, Ram? ram, Storage? storage, Laptop? laptop)
        {
            UnitPrice = dto.UnitPrice;
            UnitsInStock = dto.UnitsInStock;
            Cpu = cpu;
            Gpu = gpu;
            Ram = ram;
            Storage = storage;
            Laptop = laptop;
        }
    }
}
