using MVC14.DTOs.Products.Create;

namespace MVC14.Models
{
    public partial class Laptop
    {
        public Laptop()
        {

        }

        public Laptop(CreateLaptopDTO dto)
        {
            LaptopType = dto.LaptopType;
            Os = dto.Os;
            ScreenResolution = dto.ScreenResolution;
            Weight = dto.Weight;
            Length = dto.Length;
            LaptopComponent = new LaptopComponent()
            {
                CpuId = dto.CpuId,
                GpuId = dto.GpuId ?? null,
                RamId = dto.RamId,
                StorageId = dto.StorageId,
            };
        }
    }
}
