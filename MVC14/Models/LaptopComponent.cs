using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class LaptopComponent
{
    [Display(Name = "ID Thành Phần Laptop")]
    public int LaptopComponentId { get; set; }

    [Display(Name = "ID CPU")]
    [Required(ErrorMessage = "CPU là bắt buộc")]
    public int CpuId { get; set; }

    [Display(Name = "ID RAM")]
    [Required(ErrorMessage = "RAM là bắt buộc")]
    public int RamId { get; set; }

    [Display(Name = "ID Bộ Nhớ")]
    [Required(ErrorMessage = "Bộ nhớ là bắt buộc")]
    public int StorageId { get; set; }

    [Display(Name = "ID GPU")]
    public int? GpuId { get; set; }

    public virtual Cpu Cpu { get; set; } = null!;

    public virtual Gpu? Gpu { get; set; }

    public virtual ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();

    public virtual Ram Ram { get; set; } = null!;

    public virtual Storage Storage { get; set; } = null!;
}
