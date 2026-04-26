using System;
using System.Collections.Generic;

namespace MVC14.Models;

public partial class VwInvoice
{
    public int InvoiceId { get; set; }

    public string ProductName { get; set; } = null!;

    public int UnitPrice { get; set; }

    public int Quantity { get; set; }

    public float? DiscountPercent { get; set; }

    public int LineTotal { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CompanyName { get; set; } = null!;
}
