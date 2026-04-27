using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwGpuSpec
{
    [Display(Name = "ID GPU")]
    public int GpuId { get; set; }

    [Display(Name = "Tên GPU")]
    public string GpuName { get; set; } = null!;

    [Display(Name = "Kích Thước Bộ Nhớ (GB)")]
    [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = false)]
    public float MemorySize { get; set; }

    [Display(Name = "Loại Bộ Nhớ")]
    public string MemoryType { get; set; } = null!;

    [Display(Name = "Tốc Độ Xung Nhịp (MHz)")]
    public int Clock { get; set; }

    [Display(Name = "Unified Shaders")]
    public int UnifiedShader { get; set; }

    [Display(Name = "TMU")]
    public int Tmu { get; set; }

    [Display(Name = "ROP")]
    public int Rop { get; set; }

    [Display(Name = "GPU Tích Hợp")]
    public bool? Igpu { get; set; }

    [Display(Name = "Chiều Rộng Bus (bit)")]
    public string Bus { get; set; } = null!;

    [Display(Name = "ID SKU Sản Phẩm")]
    public int ProductSkuId { get; set; }
}
