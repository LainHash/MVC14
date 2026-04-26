namespace MVC14.DTOs.Products
{
    public class LaptopBaseDTO
    {
        public string LaptopType { get; set; } = null!;

        public int ProductSkuId { get; set; }

        public string Os { get; set; } = null!;

        public string ScreenResolution { get; set; } = null!;

        public float Length { get; set; }

        public float Weight { get; set; }

        public int CpuId { get; set; }

        public int RamId { get; set; }

        public int StorageId { get; set; }

        public int? GpuId { get; set; }
    }
}
