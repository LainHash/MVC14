using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Supplier
{
    [Display(Name = "ID Nhà Cung Cấp")]
    public int SupplierId { get; set; }

    [Display(Name = "Tên Công Ty")]
    [Required(ErrorMessage = "Tên công ty là bắt buộc")]
    [StringLength(255, MinimumLength = 2)]
    public string CompanyName { get; set; } = null!;

    [Display(Name = "Tên Liên Hệ")]
    [Required(ErrorMessage = "Tên liên hệ là bắt buộc")]
    [StringLength(150)]
    public string ContactName { get; set; } = null!;

    [Display(Name = "Quốc Gia")]
    [Required(ErrorMessage = "Quốc gia là bắt buộc")]
    [StringLength(100)]
    public string Country { get; set; } = null!;

    [Display(Name = "Số Điện Thoại")]
    [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
    [RegularExpression(@"^\+?[\d\s\-\(\)]{10,}$", ErrorMessage = "Số điện thoại không hợp lệ")]
    public string Phone { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
