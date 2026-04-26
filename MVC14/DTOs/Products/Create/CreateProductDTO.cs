namespace MVC14.DTOs.Products.Create
{
    public class CreateProductDTO : ProductBaseDTO
    {
        public CreateLaptopDTO? Laptop { get; set; }
        public CreateCpuDTO? Cpu { get; set; }
        public CreateGpuDTO? Gpu { get; set; }
        public CreateRamDTO? Ram { get; set; }
        public CreateStorageDTO? Storage { get; set; }
    }
}
