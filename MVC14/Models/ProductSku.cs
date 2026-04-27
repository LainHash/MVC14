using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class ProductSku
{
    [Display(Name = "ID SKU Sản Phẩm")]
    public int ProductSkuId { get; set; }

    [Display(Name = "Giá Đơn Vị")]
    [Required(ErrorMessage = "Giá đơn vị là bắt buộc")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue, ErrorMessage = "Giá đơn vị phải là số dương")]
    public int UnitPrice { get; set; }

    [Display(Name = "Số Lượng Tồn Kho")]
    [Required(ErrorMessage = "Số lượng tồn kho là bắt buộc")]
    [Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho phải là số dương")]
    public int UnitsInStock { get; set; }

    [Display(Name = "Đã Xóa")]
    public bool? IsDeleted { get; set; }

    [Display(Name = "ID Sản Phẩm")]
    [Required(ErrorMessage = "Sản phẩm là bắt buộc")]
    public int ProductId { get; set; }

    [Display(Name = "Ngừng Kinh Doanh")]
    public bool Discontinued { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual Cpu? Cpu { get; set; }

    public virtual Gpu? Gpu { get; set; }

    public virtual Laptop? Laptop { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Ram? Ram { get; set; }

    public virtual Storage? Storage { get; set; }
}
