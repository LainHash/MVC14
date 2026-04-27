using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Cpu
{
    [Display(Name = "ID CPU")]
    public int CpuId { get; set; }

    [Display(Name = "Số Lõi")]
    [Required(ErrorMessage = "Số lõi là bắt buộc")]
    [Range(1, 128, ErrorMessage = "Số lõi phải từ 1 đến 128")]
    public int Cores { get; set; }

    [Display(Name = "Bộ Xử Lý Lôgic")]
    [Required(ErrorMessage = "Số bộ xử lý lôgic là bắt buộc")]
    [Range(1, 256, ErrorMessage = "Bộ xử lý lôgic phải từ 1 đến 256")]
    public int Logicals { get; set; }

    [Display(Name = "TDP (W)")]
    [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
    [Range(0.0, double.MaxValue, ErrorMessage = "TDP phải là số dương")]
    public float Tdp { get; set; }

    [Display(Name = "Socket")]
    [Required(ErrorMessage = "Socket là bắt buộc")]
    [StringLength(50)]
    public string Socket { get; set; } = null!;

    [Display(Name = "Tốc Độ (MHz)")]
    [Required(ErrorMessage = "Tốc độ là bắt buộc")]
    [Range(100, 10000, ErrorMessage = "Tốc độ phải từ 100 đến 10000 MHz")]
    public int Speed { get; set; }

    [Display(Name = "Tốc Độ Turbo (MHz)")]
    [Required(ErrorMessage = "Tốc độ Turbo là bắt buộc")]
    [Range(100, 10000, ErrorMessage = "Tốc độ Turbo phải từ 100 đến 10000 MHz")]
    public int Turbo { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    [Required(ErrorMessage = "SKU sản phẩm là bắt buộc")]
    public int ProductSkuId { get; set; }

    public virtual ICollection<LaptopComponent> LaptopComponents { get; set; } = new List<LaptopComponent>();

    public virtual ProductSku ProductSku { get; set; } = null!;
}
