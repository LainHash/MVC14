using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Access
{
    [Display(Name = "ID Vai Trò")]
    public int RoleId { get; set; }

    [Display(Name = "ID Tuyến Đường")]
    public int RouteId { get; set; }

    [Display(Name = "Được Phép")]
    public bool? IsAllowed { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual RouteEntity Route { get; set; } = null!;
}
