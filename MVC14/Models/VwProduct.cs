using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwProduct
{
    [Display(Name = "ID Sản Phẩm")]
    public int ProductId { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    public int ProductSkuId { get; set; }

    [Display(Name = "ID Danh Mục")]
    public int CategoryId { get; set; }

    [Display(Name = "Tên Danh Mục")]
    public string CategoryName { get; set; } = null!;

    [Display(Name = "Tên Công Ty")]
    public string CompanyName { get; set; } = null!;

    [Display(Name = "Tên Sản Phẩm")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "UUID Sản Phẩm")]
    public Guid ProductUuid { get; set; }

    [Display(Name = "Giá Đơn Vị")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    public int UnitPrice { get; set; }

    [Display(Name = "Số Lượng Tồn Kho")]
    public int UnitsInStock { get; set; }

    [Display(Name = "Ngừng Kinh Doanh")]
    public bool Discontinued { get; set; }

    [Display(Name = "URL Hình Ảnh")]
    [DataType(DataType.Url)]
    public string? ImageUrl { get; set; }

    [Display(Name = "Mô Tả")]
    public string? Description { get; set; }

    [Display(Name = "ID Nhà Cung Cấp")]
    public int SupplierId { get; set; }

    [Display(Name = "Đã Xóa")]
    public bool IsDeleted { get; set; }

    public DateTime CreatedAt { get; set; }
}
