using System.ComponentModel.DataAnnotations;

namespace MVC14.ViewModels
{
    public class InvoiceVM
    {
        public string CustomerCode { get; set; } = null!;
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public DateOnly OrderDate { get; set; }
        public int UnitPrice { get; set; }
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
