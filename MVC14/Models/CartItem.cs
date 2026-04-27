using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class CartItem
{
    [Display(Name = "ID Mục Giỏ Hàng")]
    public int CartItemId { get; set; }

    [Display(Name = "ID Giỏ Hàng")]
    [Required(ErrorMessage = "Giỏ hàng là bắt buộc")]
    public int ShoppingCartId { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    [Required(ErrorMessage = "SKU sản phẩm là bắt buộc")]
    public int ProductSkuId { get; set; }

    [Display(Name = "Số Lượng")]
    [Required(ErrorMessage = "Số lượng là bắt buộc")]
    [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải tối thiểu là 1")]
    public int Quantity { get; set; }

    [Display(Name = "Giá Đơn Vị")]
    [Required(ErrorMessage = "Giá đơn vị là bắt buộc")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue, ErrorMessage = "Giá đơn vị phải là số dương")]
    public int UnitPrice { get; set; }

    [Display(Name = "Ngày Thêm")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime AddedDate { get; set; }

    public virtual ProductSku ProductSku { get; set; } = null!;

    public virtual ShoppingCart ShoppingCart { get; set; } = null!;
}
