using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Gpu
{
    [Display(Name = "ID GPU")]
    public int GpuId { get; set; }

    [Display(Name = "Kích Thước Bộ Nhớ (GB)")]
    [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = true)]
    [Range(0.5, 96, ErrorMessage = "Kích thước bộ nhớ phải từ 0.5 đến 96 GB")]
    public float MemorySize { get; set; }

    [Display(Name = "Loại Bộ Nhớ")]
    [Required(ErrorMessage = "Loại bộ nhớ là bắt buộc")]
    [StringLength(50)]
    public string MemoryType { get; set; } = null!;

    [Display(Name = "Tốc Độ Xung Nhịp (MHz)")]
    [Required(ErrorMessage = "Tốc độ xung nhịp là bắt buộc")]
    [Range(100, 3000, ErrorMessage = "Tốc độ xung nhịp phải từ 100 đến 3000 MHz")]
    public int Clock { get; set; }

    [Display(Name = "Unified Shaders")]
    [Required(ErrorMessage = "Unified shaders là bắt buộc")]
    [Range(1, 10000)]
    public int UnifiedShader { get; set; }

    [Display(Name = "TMU")]
    [Required(ErrorMessage = "TMU là bắt buộc")]
    [Range(1, 1000)]
    public int Tmu { get; set; }

    [Display(Name = "ROP")]
    [Required(ErrorMessage = "ROP là bắt buộc")]
    [Range(1, 1000)]
    public int Rop { get; set; }

    [Display(Name = "Chiều Rộng Bus (bit)")]
    [Required(ErrorMessage = "Chiều rộng bus là bắt buộc")]
    [StringLength(50)]
    public string Bus { get; set; } = null!;

    [Display(Name = "GPU Tích Hợp")]
    public bool? Igpu { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    [Required(ErrorMessage = "SKU sản phẩm là bắt buộc")]
    public int ProductSkuId { get; set; }

    public virtual ICollection<LaptopComponent> LaptopComponents { get; set; } = new List<LaptopComponent>();

    public virtual ProductSku ProductSku { get; set; } = null!;
}
