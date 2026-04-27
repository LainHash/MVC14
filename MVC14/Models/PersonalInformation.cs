using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class PersonalInformation
{
    [Display(Name = "ID Thông Tin Cá Nhân")]
    public int Piid { get; set; }

    [Display(Name = "Tên Đầu")]
    [Required(ErrorMessage = "Tên đầu là bắt buộc")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Tên đầu không được vượt quá 100 ký tự")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Tên Cuối")]
    [Required(ErrorMessage = "Tên cuối là bắt buộc")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Tên cuối không được vượt quá 100 ký tự")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Giới Tính")]
    public bool Gender { get; set; }

    [Display(Name = "Ngày Sinh")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateOnly Dob { get; set; }

    [Display(Name = "Thành Phố")]
    [Required(ErrorMessage = "Thành phố là bắt buộc")]
    [StringLength(100)]
    public string City { get; set; } = null!;

    [Display(Name = "Quốc Gia")]
    [Required(ErrorMessage = "Quốc gia là bắt buộc")]
    [StringLength(100)]
    public string Country { get; set; } = null!;

    [Display(Name = "Địa Chỉ")]
    [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
    [StringLength(500)]
    public string Address { get; set; } = null!;

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email là bắt buộc")]
    [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
    public string Email { get; set; } = null!;

    [Display(Name = "Số Điện Thoại")]
    [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
    [RegularExpression(@"^\+?[\d\s\-\(\)]{10,}$", ErrorMessage = "Số điện thoại không hợp lệ")]
    public string Phone { get; set; } = null!;

    [Display(Name = "CCCD/CMND")]
    [Required(ErrorMessage = "CCCD/CMND là bắt buộc")]
    [RegularExpression(@"^\d{9,12}$", ErrorMessage = "CCCD/CMND không hợp lệ")]
    public string CitizenIdentityCard { get; set; } = null!;

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }
}
