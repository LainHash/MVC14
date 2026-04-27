using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Role
{
    [Display(Name = "ID Vai Trò")]
    public int RoleId { get; set; }

    [Display(Name = "Tên Vai Trò")]
    [Required(ErrorMessage = "Tên vai trò là bắt buộc")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên vai trò phải từ 2 đến 100 ký tự")]
    public string RoleName { get; set; } = null!;

    [Display(Name = "Mô Tả")]
    [StringLength(500)]
    public string? Description { get; set; }

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
