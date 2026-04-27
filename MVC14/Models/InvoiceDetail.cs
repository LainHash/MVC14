using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class InvoiceDetail
{
    [Display(Name = "ID Chi Tiết Hóa Đơn")]
    public int InvoiceDetailId { get; set; }

    [Display(Name = "ID Hóa Đơn")]
    [Required(ErrorMessage = "Hóa đơn là bắt buộc")]
    public int InvoiceId { get; set; }

    [Display(Name = "ID Sản Phẩm")]
    [Required(ErrorMessage = "Sản phẩm là bắt buộc")]
    public int ProductId { get; set; }

    [Display(Name = "Giá Đơn Vị")]
    [Required(ErrorMessage = "Giá đơn vị là bắt buộc")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue, ErrorMessage = "Giá đơn vị phải là số dương")]
    public int UnitPrice { get; set; }

    [Display(Name = "Số Lượng")]
    [Required(ErrorMessage = "Số lượng là bắt buộc")]
    [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải tối thiểu là 1")]
    public int Quantity { get; set; }

    [Display(Name = "Phần Trăm Giảm Giá")]
    [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
    [Range(0, 100, ErrorMessage = "Phần trăm giảm giá phải từ 0 đến 100")]
    public float? DiscountPercent { get; set; }

    [Display(Name = "Tổng Dòng")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue)]
    public int LineTotal { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
