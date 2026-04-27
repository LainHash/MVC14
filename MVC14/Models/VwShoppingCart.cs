using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwShoppingCart
{
    [Display(Name = "ID Phiên")]
    public string? SessionId { get; set; }

    [Display(Name = "ID Người Dùng")]
    public int? UserId { get; set; }

    [Display(Name = "ID Mục Giỏ Hàng")]
    public int CartItemId { get; set; }

    [Display(Name = "Tên Sản Phẩm")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Số Lượng")]
    public int Quantity { get; set; }

    [Display(Name = "Giá Đơn Vị")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    public int UnitPrice { get; set; }

    [Display(Name = "Ngày Thêm")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    [DataType(DataType.DateTime)]
    public DateTime AddedDate { get; set; }

    [Display(Name = "Tổng Giá")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    public int? TotalPrice { get; set; }
}
