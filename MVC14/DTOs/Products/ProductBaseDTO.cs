namespace MVC14.DTOs.Products
{
    public class ProductBaseDTO
    {
        public string ProductName { get; set; } = null!;

        public string? Description { get; set; }

        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string? ImageUrl { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
