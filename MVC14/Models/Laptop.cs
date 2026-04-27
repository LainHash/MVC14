using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Laptop
{
    [Display(Name = "ID Laptop")]
    public int LaptopId { get; set; }

    [Display(Name = "Loại Laptop")]
    [Required(ErrorMessage = "Loại laptop là bắt buộc")]
    [StringLength(100)]
    public string LaptopType { get; set; } = null!;

    [Display(Name = "ID SKU Sản Phẩm")]
    [Required(ErrorMessage = "SKU sản phẩm là bắt buộc")]
    public int ProductSkuId { get; set; }

    [Display(Name = "Hệ Điều Hành")]
    [Required(ErrorMessage = "Hệ điều hành là bắt buộc")]
    [StringLength(100)]
    public string Os { get; set; } = null!;

    [Display(Name = "Độ Phân Giải Màn Hình")]
    [Required(ErrorMessage = "Độ phân giải màn hình là bắt buộc")]
    [StringLength(50)]
    public string ScreenResolution { get; set; } = null!;

    [Display(Name = "Chiều Dài (cm)")]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    [Range(0.0, double.MaxValue, ErrorMessage = "Chiều dài phải là số dương")]
    public float Length { get; set; }

    [Display(Name = "Trọng Lượng (kg)")]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    [Range(0.0, double.MaxValue, ErrorMessage = "Trọng lượng phải là số dương")]
    public float Weight { get; set; }

    [Display(Name = "ID Thành Phần Laptop")]
    [Required(ErrorMessage = "Thành phần laptop là bắt buộc")]
    public int LaptopComponentId { get; set; }

    public virtual LaptopComponent LaptopComponent { get; set; } = null!;

    public virtual ProductSku ProductSku { get; set; } = null!;
}
