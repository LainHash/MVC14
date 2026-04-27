using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwRamSpec
{
    [Display(Name = "ID RAM")]
    public int RamId { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    public int ProductSkuId { get; set; }

    [Display(Name = "Tên RAM")]
    public string RamName { get; set; } = null!;

    [Display(Name = "Dung Lượng RAM (GB)")]
    public int RamCapacity { get; set; }

    [Display(Name = "Thế Hệ")]
    public string Gen { get; set; } = null!;

    [Display(Name = "Tốc Độ (MHz)")]
    public int RamSpeed { get; set; }

    [Display(Name = "Kit")]
    public string Kit { get; set; } = null!;
}
