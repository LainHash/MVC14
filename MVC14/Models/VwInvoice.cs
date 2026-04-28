using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwInvoice
{
    public int CustomerId { get; set; }
    [Display(Name = "Mã Khách Hàng")]
    public string? CustomerCode { get; set; }

    public int EmployeeId { get; set; }
    
    [Display(Name = "Mã Nhân Viên")]
    public string EmployeeCode { get; set; } = null!;

    public int InvoiceId { get; set; }
    [Display(Name = "Ngày đặt hàng")]
    public DateOnly? OrderDate { get; set; }
    [Display(Name = "Ngày yêu cầu giao hàng")]
    public DateOnly? RequiredDate { get; set; }
    [Display(Name = "Ngày giao hàng")]
    public DateOnly? ShippedDate { get; set; }
    [Display(Name = "Trạng Thái")]
    public string? Status { get; set; }
    [Display(Name = "Tổng phụ")]
    [DisplayFormat(DataFormatString = "{0:N0}")]
    public int? Subtotal { get; set; }
    
    [Display(Name = "Thuế")]
    [DisplayFormat(DataFormatString = "{0:P2}")]
    public float? TaxAmount { get; set; }
    [Display(Name = "Phí vận chuyển")]
    [DisplayFormat(DataFormatString = "{0:N0}")]
    public int? ShippingFee { get; set; }
    [Display(Name = "Giảm giá vận chuyển")]
    [DisplayFormat(DataFormatString = "{0:P2}")]
    public float? ShippingDiscount { get; set; }

    [Display(Name= "Tổng tiền")]
    [DisplayFormat(DataFormatString = "{0:N0}")]
    public int? TotalAmount { get; set; }
    [Display(Name = "Ghi chú")]
    public string? Note { get; set; }
    [Display(Name = "Số lượng sản phẩm")]
    public int? Quantity { get; set; }
}
