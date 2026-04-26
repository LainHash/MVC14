using System;
using System.Collections.Generic;

namespace MVC14.Models;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public int ShoppingCartId { get; set; }

    public int ProductSkuId { get; set; }

    public int Quantity { get; set; }

    public int UnitPrice { get; set; }

    public DateTime AddedDate { get; set; }

    public virtual ProductSku ProductSku { get; set; } = null!;

    public virtual ShoppingCart ShoppingCart { get; set; } = null!;
}
