namespace MVC14.DTOs.Products
{
    public class GpuBaseDTO
    {
        public float MemorySize { get; set; }

        public string MemoryType { get; set; } = null!;

        public int Clock { get; set; }

        public int UnifiedShader { get; set; }

        public int Tmu { get; set; }

        public int Rop { get; set; }

        public string Bus { get; set; } = null!;

        public bool? Igpu { get; set; }
    }
}
