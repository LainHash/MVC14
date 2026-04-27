using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Ram
{
    [Display(Name = "ID RAM")]
    public int RamId { get; set; }

    [Display(Name = "Dung Lượng (GB)")]
    [Required(ErrorMessage = "Dung lượng là bắt buộc")]
    [Range(1, 192, ErrorMessage = "Dung lượng phải từ 1 đến 192 GB")]
    public int Capacity { get; set; }

    [Display(Name = "Thế Hệ")]
    [Required(ErrorMessage = "Thế hệ là bắt buộc")]
    [StringLength(50)]
    public string Gen { get; set; } = null!;

    [Display(Name = "Tốc Độ (MHz)")]
    [Required(ErrorMessage = "Tốc độ là bắt buộc")]
    [Range(1600, 8000, ErrorMessage = "Tốc độ phải từ 1600 đến 8000 MHz")]
    public int Speed { get; set; }

    [Display(Name = "Kit")]
    [Required(ErrorMessage = "Kit là bắt buộc")]
    [StringLength(50)]
    public string Kit { get; set; } = null!;

    [Display(Name = "ID SKU Sản Phẩm")]
    [Required(ErrorMessage = "SKU sản phẩm là bắt buộc")]
    public int ProductSkuId { get; set; }

    public virtual ICollection<LaptopComponent> LaptopComponents { get; set; } = new List<LaptopComponent>();

    public virtual ProductSku ProductSku { get; set; } = null!;
}
