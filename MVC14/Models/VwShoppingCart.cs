using System;
using System.Collections.Generic;

namespace MVC14.Models;

public partial class VwShoppingCart
{
    public string? SessionId { get; set; }

    public int? UserId { get; set; }

    public int CartItemId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Quantity { get; set; }

    public int UnitPrice { get; set; }

    public DateTime AddedDate { get; set; }

    public int? TotalPrice { get; set; }
}
