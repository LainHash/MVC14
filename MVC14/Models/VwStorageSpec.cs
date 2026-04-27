using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwStorageSpec
{
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

    [Display(Name = "ID SKU Sản Phẩm")]
    public int ProductSkuId { get; set; }
}
