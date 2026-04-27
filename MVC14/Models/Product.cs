using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Product
{
    [Display(Name = "ID Sản Phẩm")]
    public int ProductId { get; set; }

    [Display(Name = "UUID Sản Phẩm")]
    public Guid ProductUuid { get; set; }

    [Display(Name = "Tên Sản Phẩm")]
    [Required(ErrorMessage = "Tên sản phẩm là bắt buộc")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "Tên sản phẩm phải từ 3 đến 255 ký tự")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Mô Tả")]
    [StringLength(1000)]
    public string? Description { get; set; }

    [Display(Name = "ID Danh Mục")]
    [Required(ErrorMessage = "Danh mục là bắt buộc")]
    public int CategoryId { get; set; }

    [Display(Name = "ID Nhà Cung Cấp")]
    [Required(ErrorMessage = "Nhà cung cấp là bắt buộc")]
    public int SupplierId { get; set; }

    [Display(Name = "ID Hình Ảnh")]
    public int? ImageId { get; set; }

    [Display(Name = "Đã Xóa")]
    public bool? IsDeleted { get; set; }

    [Display(Name = "Ngày Tạo")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; }

    [Display(Name = "Ngày Cập Nhật")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    [DataType(DataType.DateTime)]
    public DateTime UpdatedAt { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Image? Image { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ProductSku? ProductSku { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;
}
