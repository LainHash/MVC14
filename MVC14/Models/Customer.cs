using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Customer
{
    [Display(Name = "ID Khách Hàng")]
    public int CustomerId { get; set; }

    [Display(Name = "Mã Khách Hàng")]
    [StringLength(50)]
    public string? CustomerCode { get; set; }

    [Display(Name = "ID Thông Tin Cá Nhân")]
    [Required(ErrorMessage = "Thông tin cá nhân là bắt buộc")]
    public int Piid { get; set; }

    [Display(Name = "ID Người Dùng")]
    [Required(ErrorMessage = "Người dùng là bắt buộc")]
    public int UserId { get; set; }

    [Display(Name = "Ngày Tạo")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime CreatedAt { get; set; }

    [Display(Name = "Ngày Cập Nhật")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime UpdatedAt { get; set; }

    [Display(Name = "Đã Xóa")]
    public bool? IsDeleted { get; set; }

    [Display(Name = "Ngày Xóa")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = false)]
    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual PersonalInformation Pi { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
