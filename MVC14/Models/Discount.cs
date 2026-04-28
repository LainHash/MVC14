using System;
using System.Collections.Generic;

namespace MVC14.Models;

public partial class Discount
{
    public int DiscountId { get; set; }

    public string DiscountCode { get; set; } = null!;

    public double DiscountPercent { get; set; }

    public DateOnly ExpiredDate { get; set; }

    public int Amount { get; set; }
}
