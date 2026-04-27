using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class User
{
    [Display(Name = "ID Người Dùng")]
    public int UserId { get; set; }

    [Display(Name = "UUID Người Dùng")]
    public Guid? UserUuid { get; set; }

    [Display(Name = "Tên Đăng Nhập")]
    [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Tên đăng nhập phải từ 3 đến 100 ký tự")]
    public string Username { get; set; } = null!;

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email là bắt buộc")]
    [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
    public string Email { get; set; } = null!;

    [Display(Name = "Mật Khẩu")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
    public string PasswordHash { get; set; } = null!;

    [Display(Name = "Số Dư")]
    [Range(0, int.MaxValue, ErrorMessage = "Số dư phải là số dương")]
    public int Balance { get; set; }

    [Display(Name = "ID Vai Trò")]
    [Required(ErrorMessage = "Vai trò là bắt buộc")]
    public int RoleId { get; set; }

    [Display(Name = "Hoạt Động")]
    public bool? IsActive { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
