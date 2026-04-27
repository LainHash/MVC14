using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Storage
{
    [Display(Name = "ID Bộ Nhớ")]
    public int StorageId { get; set; }

    [Display(Name = "Dung Lượng (GB)")]
    [Required(ErrorMessage = "Dung lượng là bắt buộc")]
    [Range(64, 8192, ErrorMessage = "Dung lượng phải từ 64 đến 8192 GB")]
    public int Capacity { get; set; }

    [Display(Name = "Loại Bộ Nhớ")]
    [Required(ErrorMessage = "Loại bộ nhớ là bắt buộc")]
    [StringLength(100)]
    public string MemoryType { get; set; } = null!;

    [Display(Name = "Loại Giao Tiếp")]
    [Required(ErrorMessage = "Loại giao tiếp là bắt buộc")]
    [StringLength(100)]
    public string InterfaceType { get; set; } = null!;

    [Display(Name = "Tốc Độ Đọc (MB/s)")]
    [Required(ErrorMessage = "Tốc độ đọc là bắt buộc")]
    [Range(50, 20000, ErrorMessage = "Tốc độ đọc phải từ 50 đến 20000 MB/s")]
    public int ReadSpeed { get; set; }

    [Display(Name = "Tốc Độ Ghi (MB/s)")]
    [Required(ErrorMessage = "Tốc độ ghi là bắt buộc")]
    [Range(50, 20000, ErrorMessage = "Tốc độ ghi phải từ 50 đến 20000 MB/s")]
    public int WriteSpeed { get; set; }

    [Display(Name = "ID SKU Sản Phẩm")]
    public int? ProductSkuId { get; set; }

    public virtual ICollection<LaptopComponent> LaptopComponents { get; set; } = new List<LaptopComponent>();

    public virtual ProductSku? ProductSku { get; set; }
}
