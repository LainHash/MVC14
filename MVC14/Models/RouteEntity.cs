using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class RouteEntity
{
    [Display(Name = "ID Tuyến Đường")]
    public int RouteId { get; set; }

    [Display(Name = "Mã Tuyến Đường")]
    [Required(ErrorMessage = "Mã tuyến đường là bắt buộc")]
    [StringLength(100, MinimumLength = 2)]
    public string RouteCode { get; set; } = null!;

    [Display(Name = "Đường Dẫn")]
    [Required(ErrorMessage = "Đường dẫn là bắt buộc")]
    [StringLength(500)]
    public string Path { get; set; } = null!;

    [Display(Name = "Điểm Cuối")]
    [Required(ErrorMessage = "Điểm cuối là bắt buộc")]
    [StringLength(100)]
    public string Endpoint { get; set; } = null!;

    [Display(Name = "Mô Đun")]
    [Required(ErrorMessage = "Mô đun là bắt buộc")]
    [StringLength(100)]
    public string Module { get; set; } = null!;

    [Display(Name = "Phương Thức")]
    [Required(ErrorMessage = "Phương thức là bắt buộc")]
    [StringLength(50)]
    public string Method { get; set; } = null!;

    [Display(Name = "Mô Tả")]
    [StringLength(500)]
    public string? Description { get; set; }

    [Display(Name = "Hoạt Động")]
    public bool? IsActive { get; set; }

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();
}
