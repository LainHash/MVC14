using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwInvoiceDetail
{
    public int InvoiceId { get; set; }

    [Display(Name = "Tên Sản Phẩm")]
    public string ProductName { get; set; } = null!;
    [Display(Name = "Đơn Giá")]
    public int UnitPrice { get; set; }
    [Display(Name = "Số Lượng")]
    public int Quantity { get; set; }
    [Display(Name = "Giảm Giá (%)")]
    [DisplayFormat(DataFormatString = "{0:P2}")]
    public float? DiscountPercent { get; set; }
    [Display(Name = "Thành Tiền")]
    [DisplayFormat(DataFormatString = "{0:N0}")]
    public int LineTotal { get; set; }
    [Display(Name = "Loại Sản Phẩm")]
    public string CategoryName { get; set; } = null!;
    [Display(Name = "Tên Công Ty")]
    public string CompanyName { get; set; } = null!;
}
