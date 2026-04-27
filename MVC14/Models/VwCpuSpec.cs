using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwCpuSpec
{
    [Display(Name = "ID CPU")]
    public int CpuId { get; set; }

    [Display(Name = "Tên CPU")]
    public string CpuName { get; set; } = null!;

    [Display(Name = "Số Lõi")]
    public int Cores { get; set; }

    [Display(Name = "Bộ Xử Lý Lôgic")]
    public int Logicals { get; set; }

    [Display(Name = "TDP (W)")]
    [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = false)]
    public float Tdp { get; set; }

    [Display(Name = "Socket")]
    public string Socket { get; set; } = null!;

    [Display(Name = "Tốc Độ (MHz)")]
    public int CpuSpeed { get; set; }

    [Display(Name = "Tốc Độ Turbo (MHz)")]
    public int Turbo { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    public int ProductSkuId { get; set; }
}
