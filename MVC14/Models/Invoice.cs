using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Invoice
{
    [Display(Name = "ID Hóa Đơn")]
    public int InvoiceId { get; set; }

    [Display(Name = "UUID Hóa Đơn")]
    public Guid InvoiceUuid { get; set; }

    [Display(Name = "ID Khách Hàng")]
    [Required(ErrorMessage = "Khách hàng là bắt buộc")]
    public int CustomerId { get; set; }

    [Display(Name = "ID Nhân Viên")]
    [Required(ErrorMessage = "Nhân viên là bắt buộc")]
    public int EmployeeId { get; set; }

    [Display(Name = "Ngày Đặt Hàng")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateOnly? OrderDate { get; set; }

    [Display(Name = "Ngày Yêu Cầu")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateOnly? RequiredDate { get; set; }

    [Display(Name = "Ngày Gửi Hàng")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateOnly? ShippedDate { get; set; }

    [Display(Name = "Trạng Thái")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Display(Name = "Tổng Phụ")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue)]
    public int? Subtotal { get; set; }

    [Display(Name = "Số Tiền Thuế")]
    [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, double.MaxValue)]
    public float? TaxAmount { get; set; }

    [Display(Name = "Tổng Tiền")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue)]
    public int? TotalAmount { get; set; }

    [Display(Name = "Ghi Chú")]
    [StringLength(1000)]
    public string? Note { get; set; }

    [Display(Name = "Phí Vận Chuyển")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue)]
    public int? ShippingFee { get; set; }

    [Display(Name = "Giảm Giá Vận Chuyển")]
    [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, double.MaxValue)]
    public float? ShippingDiscount { get; set; }

    [Display(Name = "Ngày Tạo")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime? CreatedAt { get; set; }

    [Display(Name = "Ngày Cập Nhật")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime? UpdatedAt { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();
}
