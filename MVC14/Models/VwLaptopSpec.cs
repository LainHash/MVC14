using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwLaptopSpec
{
    [Display(Name = "ID Laptop")]
    public int? LaptopId { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    public int? ProductSkuId { get; set; }

    [Display(Name = "Loại Laptop")]
    public string? LaptopType { get; set; }

    [Display(Name = "Tên Laptop")]
    public string? LaptopName { get; set; }

    [Display(Name = "Hệ Điều Hành")]
    public string? Os { get; set; }

    [Display(Name = "Độ Phân Giải Màn Hình")]
    public string? ScreenResolution { get; set; }

    [Display(Name = "Chiều Dài (cm)")]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = false)]
    public float? Length { get; set; }

    [Display(Name = "Trọng Lượng (kg)")]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = false)]
    public float? Weight { get; set; }

    [Display(Name = "ID CPU")]
    public int? CpuId { get; set; }

    [Display(Name = "Tên CPU")]
    public string? CpuName { get; set; }

    [Display(Name = "Số Lõi")]
    public int? Cores { get; set; }

    [Display(Name = "Bộ Xử Lý Lôgic")]
    public int? Logicals { get; set; }

    [Display(Name = "TDP (W)")]
    [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = false)]
    public float? Tdp { get; set; }

    [Display(Name = "Socket")]
    public string? Socket { get; set; }

    [Display(Name = "Tốc Độ CPU (MHz)")]
    public int? CpuSpeed { get; set; }

    [Display(Name = "Tốc Độ Turbo (MHz)")]
    public int? Turbo { get; set; }

    [Display(Name = "ID GPU")]
    public int? GpuId { get; set; }

    [Display(Name = "Tên GPU")]
    public string? GpuName { get; set; }

    [Display(Name = "Kích Thước Bộ Nhớ GPU (GB)")]
    [DisplayFormat(DataFormatString = "{0:F1}", ApplyFormatInEditMode = false)]
    public float? MemorySize { get; set; }

    [Display(Name = "Loại Bộ Nhớ GPU")]
    public string? MemoryType { get; set; }

    [Display(Name = "Tốc Độ Xung Nhịp GPU (MHz)")]
    public int? Clock { get; set; }

    [Display(Name = "Unified Shaders")]
    public int? UnifiedShader { get; set; }

    [Display(Name = "TMU")]
    public int? Tmu { get; set; }

    [Display(Name = "ROP")]
    public int? Rop { get; set; }

    [Display(Name = "GPU Tích Hợp")]
    public bool? Igpu { get; set; }

    [Display(Name = "Chiều Rộng Bus (bit)")]
    public string? Bus { get; set; }

    [Display(Name = "ID RAM")]
    public int? RamId { get; set; }

    [Display(Name = "Tên RAM")]
    public string? RamName { get; set; }

    [Display(Name = "Dung Lượng RAM (GB)")]
    public int? RamCapacity { get; set; }

    [Display(Name = "Thế Hệ")]
    public string? Gen { get; set; }

    [Display(Name = "Tốc Độ RAM (MHz)")]
    public int? RamSpeed { get; set; }

    [Display(Name = "Kit")]
    public string? Kit { get; set; }

    [Display(Name = "ID Bộ Nhớ")]
    public int StorageId { get; set; }

    [Display(Name = "Tên Bộ Nhớ")]
    public string StorageName { get; set; } = null!;

    [Display(Name = "Dung Lượng Bộ Nhớ (GB)")]
    public int StorageCapacity { get; set; }

    [Display(Name = "Loại Bộ Nhớ")]
    public string StorageType { get; set; } = null!;

    [Display(Name = "Loại Giao Tiếp")]
    public string InterfaceType { get; set; } = null!;

    [Display(Name = "Tốc Độ Đọc (MB/s)")]
    public int ReadSpeed { get; set; }

    [Display(Name = "Tốc Độ Ghi (MB/s)")]
    public int WriteSpeed { get; set; }
}
