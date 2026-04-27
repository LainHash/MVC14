using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwInvoice
{
    [Display(Name = "ID Hóa Đơn")]
    public int InvoiceId { get; set; }

    [Display(Name = "Tên Sản Phẩm")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Giá Đơn Vị")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    public int UnitPrice { get; set; }

    [Display(Name = "Số Lượng")]
    public int Quantity { get; set; }

    [Display(Name = "Phần Trăm Giảm Giá")]
    [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
    public float? DiscountPercent { get; set; }

    [Display(Name = "Tổng Cộng")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    public int LineTotal { get; set; }

    [Display(Name = "Tên Danh Mục")]
    public string CategoryName { get; set; } = null!;

    [Display(Name = "Tên Công Ty")]
    public string CompanyName { get; set; } = null!;
}
