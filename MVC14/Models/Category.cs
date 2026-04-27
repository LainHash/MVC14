using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Category
{
    [Display(Name = "ID Danh Mục")]
    public int CategoryId { get; set; }

    [Display(Name = "Tên Danh Mục")]
    [Required(ErrorMessage = "Tên danh mục là bắt buộc")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Tên danh mục phải từ 2 đến 150 ký tự")]
    public string CategoryName { get; set; } = null!;

    [Display(Name = "Mô Tả")]
    [StringLength(500)]
    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
