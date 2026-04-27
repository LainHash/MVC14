using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class ShoppingCart
{
    [Display(Name = "ID Giỏ Hàng")]
    public int ShoppingCartId { get; set; }

    [Display(Name = "ID Người Dùng")]
    public int? UserId { get; set; }

    [Display(Name = "ID Phiên")]
    [StringLength(128)]
    public string? SessionId { get; set; }

    [Display(Name = "Ngày Tạo")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime CreatedAt { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual User? User { get; set; }
}
