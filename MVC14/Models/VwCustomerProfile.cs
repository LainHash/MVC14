using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class VwCustomerProfile
{
    [Display(Name = "Mã Khách Hàng")]
    public string? CustomerCode { get; set; }

    [Display(Name = "ID Người Dùng")]
    public int UserId { get; set; }

    [Display(Name = "Tên Đầu")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Tên Cuối")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Giới Tính")]
    public bool Gender { get; set; }

    [Display(Name = "Ngày Sinh")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Date)]
    public DateOnly Dob { get; set; }

    [Display(Name = "Thành Phố")]
    public string City { get; set; } = null!;

    [Display(Name = "Quốc Gia")]
    public string Country { get; set; } = null!;

    [Display(Name = "Địa Chỉ")]
    public string Address { get; set; } = null!;

    [Display(Name = "Email Cá Nhân")]
    [DataType(DataType.EmailAddress)]
    public string PersonalEmail { get; set; } = null!;

    [Display(Name = "Số Điện Thoại")]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; } = null!;

    [Display(Name = "CCCD/CMND")]
    public string CitizenIdentityCard { get; set; } = null!;

    [Display(Name = "UUID Người Dùng")]
    public Guid? UserUuid { get; set; }

    [Display(Name = "Tên Đăng Nhập")]
    public string Username { get; set; } = null!;

    [Display(Name = "Email Tài Khoản")]
    [DataType(DataType.EmailAddress)]
    public string AccountEmail { get; set; } = null!;

    [Display(Name = "Số Dư")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    public int Balance { get; set; }

    [Display(Name = "Vai Trò")]
    public string RoleName { get; set; } = null!;
}
