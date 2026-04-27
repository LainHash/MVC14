using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Department
{
    [Display(Name = "ID Phòng Ban")]
    public int DepartmentId { get; set; }

    [Display(Name = "Tên Phòng Ban")]
    [Required(ErrorMessage = "Tên phòng ban là bắt buộc")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Tên phòng ban phải từ 2 đến 150 ký tự")]
    public string DepartmentName { get; set; } = null!;

    [Display(Name = "ID Phòng Ban Cha")]
    public int? ParentDepartmentId { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Department> InverseParentDepartment { get; set; } = new List<Department>();

    public virtual Department? ParentDepartment { get; set; }
}
