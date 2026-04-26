namespace MVC14.DTOs.Products
{
    public class RamBaseDTO
    {
        public int Capacity { get; set; }

        public string Gen { get; set; } = null!;

        public int Speed { get; set; }

        public string Kit { get; set; } = null!;
    }
}
