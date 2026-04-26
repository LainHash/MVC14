namespace MVC14.DTOs.Products.Update
{
    public class UpdateProductDTO : ProductBaseDTO
    {
        public bool Discontinued { get; set; }
        public UpdateLaptopDTO? Laptop { get; set; }
        public UpdateCpuDTO? Cpu { get; set; }
        public UpdateGpuDTO? Gpu { get; set; }
        public UpdateRamDTO? Ram { get; set; }
        public UpdateStorageDTO? Storage { get; set; }
    }
}
