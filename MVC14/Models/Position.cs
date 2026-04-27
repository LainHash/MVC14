using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Position
{
    [Display(Name = "ID Chức Vụ")]
    public int PositionId { get; set; }

    [Display(Name = "Tên Chức Vụ")]
    [Required(ErrorMessage = "Tên chức vụ là bắt buộc")]
    [StringLength(150, MinimumLength = 2)]
    public string PositionName { get; set; } = null!;

    [Display(Name = "Cấp Độ")]
    [Range(1, 10, ErrorMessage = "Cấp độ phải từ 1 đến 10")]
    public int? Level { get; set; }

    [Display(Name = "Lương Cơ Bản")]
    [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = false)]
    [DataType(DataType.Currency)]
    [Range(0, int.MaxValue, ErrorMessage = "Lương phải là số dương")]
    public int? BaseSalary { get; set; }

    [Display(Name = "Hoạt Động")]
    public bool? IsActive { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
