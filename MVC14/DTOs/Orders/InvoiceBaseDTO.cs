using System.ComponentModel.DataAnnotations;

namespace MVC14.DTOs.Orders
{
    public class InvoiceBaseDTO
    {
        public string CustomerCode { get; set; } = null!;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public DateOnly OrderDate { get; set; }
        public int UnitPrice { get; set; }

        [Range(0, int.MaxValue, ErrorMessage ="Số lượng phải lớn hơn 0!")]
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "P2")]
        public float DiscountPercent { get; set; }

        [DisplayFormat(DataFormatString = "N0")]
        public int LineTotal { get; set; }
        [DisplayFormat(DataFormatString = "N0")]
        public int Subtotal { get; set; }
        [DisplayFormat(DataFormatString = "P2")]
        public float TaxAmount { get; set; }
        [DisplayFormat(DataFormatString = "N0")]
        public int TotalAmount { get; set; }
        public string? Note { get; set; }
    }
}
