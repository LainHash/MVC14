using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Employee
{
    [Display(Name = "ID Nhân Viên")]
    public int EmployeeId { get; set; }

    [Display(Name = "Mã Nhân Viên")]
    [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
    [StringLength(50)]
    public string EmployeeCode { get; set; } = null!;

    [Display(Name = "ID Người Dùng")]
    [Required(ErrorMessage = "Người dùng là bắt buộc")]
    public int UserId { get; set; }

    [Display(Name = "ID Thông Tin Cá Nhân")]
    public int? Piid { get; set; }

    [Display(Name = "Email Công Ty")]
    [Required(ErrorMessage = "Email công ty là bắt buộc")]
    [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
    public string CompanyEmail { get; set; } = null!;

    [Display(Name = "Ngày Tuyển Dụng")]
    [Required(ErrorMessage = "Ngày tuyển dụng là bắt buộc")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateOnly HiredDate { get; set; }

    [Display(Name = "Trạng Thái")]
    [StringLength(50)]
    public string? Status { get; set; }

    [Display(Name = "ID Chức Vụ")]
    public int? PositionId { get; set; }

    [Display(Name = "ID Phòng Ban")]
    public int? DepartmentId { get; set; }

    [Display(Name = "ID Quản Lý")]
    public int? ManagerId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Employee? Manager { get; set; }

    public virtual PersonalInformation? Pi { get; set; }

    public virtual Position? Position { get; set; }

    public virtual User User { get; set; } = null!;
}
